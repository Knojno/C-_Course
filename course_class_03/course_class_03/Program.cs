using System;
using System.Globalization;
namespace course_class_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AreaX = x.Area();
            double AreaY = y.Area();

            Console.WriteLine("Area x" + AreaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area y" + AreaY.ToString("F4", CultureInfo.InvariantCulture));

            if (AreaX > AreaY)
            {
                Console.WriteLine("A maior Area é do X");
            }
            else
            {
                Console.WriteLine("A mairo Area é do Y");
            }
        }
    }
}
