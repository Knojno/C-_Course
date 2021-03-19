using System;
using System.Globalization;

namespace course_class_02
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            //CLASS 06 to 8 and CLASS 11
            //CLASS 6---------
            Console.WriteLine("Digite três numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior =" + resultado);
            //----------CLASS 6
            //
            Console.WriteLine("Digite um numero");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite um numero");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //
            Console.Write("Quantos numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor: #{0}:", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }

            Console.WriteLine("Soma =" + soma);
            //
            // HA UMA OUTRA SOLUÇÃO PARA A AULA 11 
            // FOR CLASS 11, HAVE ANOTHER SOLUTION USING A CLASS "CALCULATOR.CS "
            // CLASS 11 ------------------------
            Console.Write("Entre com o valor do raio ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circuferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferencia " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi " + Pi.ToString("F2", CultureInfo.InvariantCulture));
            //------------------------- CLASS 11
            //SECOND SOLUTION TO CLASS 11
            Console.Write("Entre com o valor do raio ");
            double raio1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ1 = Calculator.Circuferencia(raio1);
            double vol1 = Calculator.Volume(raio1);

            Console.WriteLine("Circunferencia " + circ1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume " + vol1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        //CLASS 6 ------
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
        //---------CLASS 6
        //CLASS 11 ---------------------
        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
        //-----------------------CLASS11
    }
}
