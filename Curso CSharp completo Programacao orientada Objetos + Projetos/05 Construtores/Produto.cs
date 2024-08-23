using System;
using System.Globalization;

namespace PeodutoClass
{
    class Produto
    {
        private string _nome;
        public double Preco {get; private set; }
        public int Quantidade {get; private set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = 0;
        }

        public override string ToString()
        {
            return "Nome: " + _nome + ", Preco: " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", Quantidade: " + Quantidade + ", Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public string Nome 
        {
					get { return _nome; }
					set { 
						  
						  if (value != null && value.Length > 1)
						  {
						      _nome = value;
						  }
					}
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

    }
}