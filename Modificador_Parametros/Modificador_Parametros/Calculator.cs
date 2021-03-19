using System;
using System.Collections.Generic;
using System.Text;

namespace Modificador_Parametros
{
    class Calculator
    {
        public static void Triple(int origin, out int result)
        {
            y = y * 3;
        }
        /*public static void Triple(ref int x)
        {
            x = x * 3;
        }*/
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
