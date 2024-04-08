using System;
using System.Globalization;

namespace PeodutoClass
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public override string ToString()
        {
            return "Nome: " + Nome + ", Preco: " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", Quantidade: " + Quantidade + ", Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

    }
}