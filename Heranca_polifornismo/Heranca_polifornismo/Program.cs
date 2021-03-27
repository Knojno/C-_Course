using System;
using Heranca_polifornismo.Entities;

namespace Heranca_polifornismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
            Account acc6 = new Account(1001, "Krug", 500.0);
            Account acc7 = new SavingsAccount(1002, "Vinia", 500.0, 0.01);

            acc6.WithDraw(10.0);
            acc7.WithDraw(10.0);
            Console.WriteLine("["+ acc6.Balance + "]"+"[" + acc7.Balance + "]");

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            //DOWNCASTING -> usar se realmente for nescessario
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
}
