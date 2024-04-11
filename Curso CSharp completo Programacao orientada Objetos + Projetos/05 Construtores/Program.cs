using System;
using System.Globalization;
using PeodutoClass;

namespace Main
{
    class Core
    {
        static void Main()
        {
            ExecutarExemploProduto();
        }

        static void ExecutarExemploProduto()
        {
            Console.WriteLine("Entre com os dados do Produto.");
            
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade em estoque:");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new(nome, preco);

            Console.WriteLine("Dados do produto: " + produto) ;

            System.Console.WriteLine();
            System.Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque");
            quantidade = int.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.AdicionarProduto(quantidade);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + produto);

            System.Console.WriteLine();
            System.Console.WriteLine("Digite o número de produtos a ser removido do estoque");
            quantidade = int.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.RemoverProduto(quantidade);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + produto);

            System.Console.ReadLine();            

        }

    }        
}

