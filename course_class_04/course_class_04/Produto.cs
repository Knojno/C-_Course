using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace course_class_04
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalemEstoque()
        {
            return Preco * Quantidade;

        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }


        public override string ToString()
        {
            return Nome + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + "," + Quantidade + "unidades, Total: $ "
                + ValorTotalemEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
