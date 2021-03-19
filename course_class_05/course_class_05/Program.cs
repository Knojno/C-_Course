using System;
using System.Globalization;
using System.Collections.Generic;

namespace course_class_05
{
    class Program
    {
        // CLASS 12, 13, 14
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            //Console.WriteLine(p.GetNome());
            //p.SetNome("TV 4K");
            //Console.WriteLine(p.GetNome());
            /*Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
             //Construtor
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);*/
            
            //---------------------------------------------------------------
            // CLASS "LIST"
            List<string> list = new List<string>();
            list.Add("Maria");//"Add" adiciona no final da lista 
            list.Add("João");
            list.Add("Carlos");
            list.Add("Anna");
            list.Add("Julio");
            list.Add("Wagner");
            list.Add("Vitoria");
            list.Add("Arthur");
            list.Add("Alex");
            list.Add("Gustavo");
            list.Insert(2, "Marco"); //"Insert" adiciona na posição desejada


            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count = " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');//ira pegar o primeiro item que tem letra inicial 'A'
            Console.WriteLine("First A = " + s1);
            string s2 = list.FindLast(x => x[0] == 'A');//ira pegar o ultimo item que tem letra inicial 'A'
            int pos1 = list.FindIndex(x => x[0] == 'A');//ira pegar a primeira posição item que tem letra inicial 'A'
            Console.WriteLine(pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A'); //ira pegar a ultima posição item que tem letra inicial 'A'
            Console.WriteLine(pos2);
            List<string> list2 = list.FindAll(x => x.Length == 5);
            // ira procurar itens que tenham o mesmo tamanho dentro da lista
            Console.WriteLine("------------------");
            foreach (string obj2 in list2)
            {
                Console.WriteLine(obj2);
            }
            list.Remove("Alex");
            //Ira remover item especifico da lista
            list.RemoveAll(x => x[0] == 'M');
            // Ira remover tudo que tem a letra 'M' inicial
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Ira remover o que esta na posição 2
            Console.WriteLine("------------------------------------------");
            list.RemoveRange(2, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Apartir da posição '2' ele ira remover 2 elementos
            //
            //
            //-----------------------------------------------------------------------------------------------------
            //double x = null; -> erro
            Nullable<double> m = null;
            double? y = 10.0;
            double? a = m ?? 5;
            double? b = y ?? 5;


            Console.WriteLine(m.GetValueOrDefault()); // pega o valor que ta na variavel ou valor padrão
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(m.HasValue);// fala em bool se a variavel possui valor
            Console.WriteLine(y.HasValue);
            Console.WriteLine("----------------------------------------------------------------");
            if (m.HasValue)
            {
                Console.WriteLine(m.Value);
            }
            else
            {
                Console.WriteLine("Valor de X é null");
            }
            Console.WriteLine("----------------------------------------------------------------");
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Valor de Y é null");
            }

            Console.WriteLine("----------------------------------------------------------------");
            Point p1 = new Point();
            p1.q = 10;
            p1.w = 20;
            Console.WriteLine(p);
        }
    }
}
