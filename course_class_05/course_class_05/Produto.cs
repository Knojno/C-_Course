using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace course_class_05
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }//Auto Propriete
        public int Quantidade { get; private set; }
        public Produto(string nome, double preco, int quantidade) // construtor
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //Propriete
        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1) { _nome = value; } }
        }
        /*public double Preco
       {
           get { return _preco; }
       }
       public int Quantidade
       {
           get { return _quantidade; }
       }
       public string GetNome()
       {
           return _nome;
       }
       public void SetNome(string nome)
       {
           if (nome != null && nome.Length > 1)
           {
               _nome = nome;
           }
       }

       public double GetPreco()
       {
           return _preco;
       }

       public int GetQuantidade()
       {
           return _quantidade;
       }*/
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return
             ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
