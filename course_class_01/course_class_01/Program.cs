using System;

namespace course_class_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // CLASS 01 A 05
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10 / 8;  // da para colocar 10.0 em vez do casting
            //formula de baskara
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c; // Potenciação = Math.Pow("variavel", "potencia") 
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Math.Sqrt(delta) = raiz quadrada
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            //
            string frase = Console.ReadLine(); // le o que digitou no executavel até a quebra de linha
            string x = Console.ReadLine();
            string z = Console.ReadLine();
            string y = Console.ReadLine();
            string S = Console.ReadLine();
            string[] v = S.Split(' '); // separa as palavras em espaçamento na frase
            // pode ser tambem : string[] v = Console.ReadLine().Split(' ');
            string d = v[0];
            string f = v[1];
            string g = v[2];
            Console.WriteLine("Voce digitou");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            //
            int n5 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n6 = double.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);
            Console.WriteLine("Voce digitou:");
            Console.WriteLine(n5);
            Console.WriteLine(ch);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            //
            Console.WriteLine("Aula Operadores Logicos");
            int h = 10;
            bool c1 = h < 10;
            bool c2 = h > 20;
            bool c3 = h > 10;
            bool c4 = h > 5;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("------------------");
            bool c5 = h <= 10;
            bool c6 = h >= 10;
            bool c7 = h == 10;
            bool c8 = h != 10;
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
            Console.WriteLine("------------------");
            bool c9 = 4 != 5;
            Console.WriteLine(c9);
            bool c10 = 2 > 3 && 4 != 5;
            Console.WriteLine(c10);
            bool c11 = 2 > 3 || 4 != 5; // condição verdadeira
            Console.WriteLine(c11);
            bool c12 = !(2 > 3) && 4 != 5; // ! transforma uma condição Falsa em Verdadeira ou vice versa
            Console.WriteLine(c12); // verdadeira
            Console.WriteLine("-----------------");
            bool c13 = 10 < 5; // falsa
            bool c14 = c11 || c12 && c13;
            Console.WriteLine(c14);
            // > =  maio
            // < = menor
            // >= maior ou igual
            // <= menor ou igual
            // ==  igual
            // != diferente 
            // && = E
            // || = OU
            // ! = NÃO
            // precedencia = resolve primeiro (! -> && -> ||)
            Console.WriteLine("__________________________");
            Console.WriteLine("Aula Estrutura Condicional IF");
            Console.WriteLine("Entre com um numero inteiro");
            int m = int.Parse(Console.ReadLine());
            if (m % 2 == 0) // estrutura para ver se o numero é par
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR ");
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Qual Hora atual");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
