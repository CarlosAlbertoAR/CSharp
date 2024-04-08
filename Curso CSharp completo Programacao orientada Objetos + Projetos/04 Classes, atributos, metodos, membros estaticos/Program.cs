using System;
using System.Globalization;
using TrianguloClass;
using PeodutoClass;

namespace Main
{
    class Core
    {
        static void Main()
        {
            ExecutarExemploProduto();
            // ExecutarExemploTriangulo();
        }

        static void ExecutarExemploProduto()
        {
            Produto produto = new();

            Console.WriteLine("Entre com os dados do Produto.");
            
            Console.WriteLine("Nome:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade em estoque:");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(produto) ;

            System.Console.ReadLine();            

        }

        static void ExecutarExemploTriangulo()
        {
            Triangulo trianguloA, trianguloB;
            trianguloA = new();
            trianguloB = new();
            string maiorArea;
            
            System.Console.WriteLine("Informe as medida do triângulo A (lados AxBxC):");
            trianguloA.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloA.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloA.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloA.CalcularArea();

            System.Console.WriteLine("Informe as medida do triângulo B (lados AxBxC):");
            trianguloB.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloB.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloB.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloB.CalcularArea();

            if (trianguloA.Area > trianguloB.Area) 
            {
                maiorArea = "A";
            } else
            {
                maiorArea = "B";
            }

            System.Console.WriteLine("A área do triangulo A é " + trianguloA.Area);
            System.Console.WriteLine("A área do triangulo B é " + trianguloB.Area);
            System.Console.WriteLine("O triângulo de maior área é " + maiorArea);
            System.Console.ReadLine();
        }

    }        
}

