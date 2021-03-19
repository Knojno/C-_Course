using System;

namespace Modificador_Parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            Console.WriteLine(s1);

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);

            string[] vect = new string[] { "Maria", "Alex", "Bob" };
            for (int i; i <vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
                Console.WriteLine("------------------------------------");
            }
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
            
            
            
            
            /*int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);*/


        }
    }
}
