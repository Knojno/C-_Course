using System;
using System.Globalization;
using course_class_06.StringBuilderEntities;

namespace course_class_06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //CLASS VECTOR
            
            Console.WriteLine("Número de Produtos");
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome do produto");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço do produto");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Price = price };
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vect[i].Nome + "," + vect[i].Price);
                Console.WriteLine("----------------------------------------------------------------");
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
           
            //
            //
            // CLASS DATETIME
            
            DateTime d6 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d6);
            DateTime d7 = DateTime.Parse("15/12/2015");
            Console.WriteLine(d7);
            DateTime d8 = DateTime.ParseExact("200-12-08", "yyyy,MM,dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d8);
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(9000000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromTicks(9000000000L);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            DateTime d2 = new DateTime(2021, 03, 17);
            DateTime d3 = new DateTime(2021, 03, 17, 16, 02, 3);
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            //
            //
            //CLASS MATRIZ
            Console.WriteLine("Matriz is size:");
            int n1 = int.Parse(Console.ReadLine());
            int[,] mat1 = new int[n1, n1];
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine(i + "º" + "Line:");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n1; j++)
                {
                    mat1[i, j] = int.Parse(values[j]);
                }
            }
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Diagonal : " + "[" + mat1[i, i] + "]");
            }
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write("[" + mat1[i, j] + "]");
                    if (j == n1 - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    if (mat1[i, j] < 0)
                    {
                        Console.WriteLine("Number:" + "[" + mat1[i, j] + "]");
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers" + count);

            //
            //
            //String Builder

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:45"),
                "Traveling to New Zealand",
                "Im going to visit this wonderful country",
                12);
            p1.addComent(c1);
            p1.addComent(c2);
            Console.WriteLine(p1);
            //
            //
            //
            //SWITCH
            Console.WriteLine("Number");
            int x = int.Parse(Console.ReadLine());
            string day;
            switch (x)
            {
                case 1:
                    day = "MONDAY";
                    break;
                case 2:
                    day = "Tuesday";
                    break;

                default:
                    day = "Invalido";
                    break;

            }
            Console.WriteLine(day);
            Console.WriteLine("-------------------------------------------------------------------------");


            //EXPRESSÃO CONDICIONAL
            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;
            if (preco < 20.00)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine(desconto);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Preço:");
            double preco2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto2 = (preco < 20.00) ? preco2 * 0.1 : preco2 * 0.05;
            Console.WriteLine(desconto2);




        }
    }
}
