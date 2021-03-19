using System;
using System.Globalization;
namespace course_class_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto");
            Console.WriteLine("Nome:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantida:");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto:" + p);
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionados no estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine();
            Console.WriteLine("Tabela Atualizada" + p);
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removidos no estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine();
            Console.WriteLine("Tabela Atualizada" + p);
        }
    }
}
