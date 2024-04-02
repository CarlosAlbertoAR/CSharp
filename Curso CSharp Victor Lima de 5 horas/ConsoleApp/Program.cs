using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Console.WriteLine("Hello, World!");
            */

            /* Variaveis
            int segundaGerraMundial = 1942;
            string corFavorita = "Azul";
            float velocidadeF1 = 294.48f;
            bool ocorreuSegundaGerraMundial = true;
            
            Console.WriteLine(segundaGerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(ocorreuSegundaGerraMundial);

            velocidadeF1 = 300f;
            corFavorita = "Roxo" ;

            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);

            */

            /* Capturando entrada do usuário

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Bem vindo " + nome);
            
            */

            /* Operações matemáticas 

            int numeroQualquer = 20 + 20 - 5;
            int numeroMultiplicado = 10 * 90;
            float numeroDividido = 90 / 10;
            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMultiplicado);
            Console.WriteLine(numeroDividido);
            */
            
            
            /*

            Console.WriteLine("Informe sua idade:");

            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança.");
            }else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolecente.");                
            }else if (idade >= 19 && idade <= 59)
            {
                Console.WriteLine("Você é um adulto.");                                
            }
            else
                Console.WriteLine("Você é um idodo.");                                

            Console.ReadLine();    
            */

            /* Funções */

            exibirMsg();
            exibirMsg();
            exibirMsg();
            Console.ReadLine();

        }

        static void exibirMsg()
        {
    	    Console.WriteLine("Estamos usando funções");
        }

    }    
}

