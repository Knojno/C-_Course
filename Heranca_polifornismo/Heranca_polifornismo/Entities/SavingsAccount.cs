using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_polifornismo.Entities
{
    sealed class SavingsAccount : Account
        //SEALED -> evita herdar da classe selada
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate): base (number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // SEALED num metodo proibe que ele possa ser sobreposto em outras classes filhas 
        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
