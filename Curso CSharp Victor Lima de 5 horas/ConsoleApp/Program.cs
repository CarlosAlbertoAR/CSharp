using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;

namespace HelloWord
{
    class Program
    {
        enum Cor {Azul, Verde, Amarelo, Vermelho }    
      	enum Opcao {Criar= 1, Editar, Deletar, Listar, Atualizar}

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

            //exibirMsg();
            
            //GerarPreco(5.00f, 43);
            
            //float soma = Somar(2, 5, 10);
            //Console.Write("A soma é " + soma);
            //Console.ReadLine();
            
            //Console.WriteLine(produtos[1]);
            
            //exibirMenu();

            //estruturaWhile();

            //estruturaDoWhile();

            //estruturaForEach();

            //estruturaForComArray();

            estruturaForDecrecente();

        }

        static void exibirMsg()
        {
    	    Console.WriteLine("Estamos usando funções");
        }

       	static void GerarPreco(float Custo, float Margem)
	    {
    		Console.WriteLine("O valor do Produto é " + (Custo + (Custo * (Margem / 100))));
    	}

		static float Somar(int a, int b, int c)
    	{
		    return a + b + c;
	    }

        //Arrays
        string[] produtos = new string[5] 
        {
	        "Sea of thieves",
	        "FIFA",
	        "Minecraft",
	        "Half-Life",
	        "Portal",
        };

        static void exibirMenu()
        {
	
        	Console.WriteLine("Selecione uma das opções abaixo:");
	        Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
        	int index = int.Parse(Console.ReadLine());
        	Opcao opcaoSelecionada = (Opcao)index;

        	switch (opcaoSelecionada)
	        {
		        case Opcao.Criar:
        			Console.WriteLine("Criando a opção selecionada");
        			break;
			
        		case Opcao.Editar:
    			    Console.WriteLine("Editando a opção selecionada");
    			    break;

        		case Opcao.Deletar:
			        Console.WriteLine("Deletando a opção selecionada");
    			    break;

        		case Opcao.Listar:
			        Console.WriteLine("Listando a opção selecionada");
    			    break;

        		case Opcao.Atualizar:
			        Console.WriteLine("Atualizando a opção selecionada");
    			    break;
	    
                default:
            		Console.WriteLine("Opcao não encontrada.");
                    break;
	        }	

            Console.ReadLine();
        }

        static void estruturaWhile()
        {
            int contador = 0;

            while (contador < 10)
            {
                Console.WriteLine("Executando o while.");
                contador++;
            }

            Console.ReadLine();
        } 

        static void estruturaDoWhile()
        {
            int contador = 0;

            do
            {
                Console.WriteLine("Executando do while");
                contador++;
            } while(contador < 20);

            Console.ReadLine();            
        }   

        static void estruturaForEach()
        {
            string[] palavras = {"Victor", "Lima", "Guia do Programador", "Formação", "Node", "Curso"};

            foreach(string palavra in palavras)
            {
                Console.WriteLine("Palavra da vez " + palavra);
            }
            
            Console.ReadLine();                        
        }
        
        static void estruturaFor()
        {

            for (int contador = 0; contador < 0; contador++)
            {
                Console.WriteLine("Executando For");
            }
        }

        static void estruturaForComArray()
        {
            string[] palavras = {"Victor", "Lima", "Guia do Programador", "Formação", "Node", "Curso"};

            for (int contador = 0; contador <palavras.Length; contador++)
            {
                Console.WriteLine("Executando For na palavra: " + palavras[contador]);
            }

            Console.ReadLine();                        
        }

        static void estruturaForDecrecente()
        {
            for(int contador = 6; contador > 0; contador--)
            {
                Console.WriteLine("Executando for Descrecente: " + contador);                        
            }

            Console.ReadLine();                                    
            
        }

    }    
}

