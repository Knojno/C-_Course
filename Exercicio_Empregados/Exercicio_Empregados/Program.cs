using System;
using System.Collections.Generic;
using Exercicio_Empregados.Entidades;
using System.Globalization;

namespace Exercicio_Empregados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.WriteLine("Outsourced?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name");
                string name = Console.ReadLine();
                Console.WriteLine("Hours");
                int hour = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'Y')
                {
                    Console.WriteLine("Additional charges");
                    double charges = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hour, valueperhour, charges));
                }
                else
                {
                    list.Add(new Employee(name, hour, valueperhour));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS");
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp.Name + "-$"+ emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
