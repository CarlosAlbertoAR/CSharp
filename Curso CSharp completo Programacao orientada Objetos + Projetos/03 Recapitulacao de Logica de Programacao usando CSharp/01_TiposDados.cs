using System;

namespace TiposDeDados
{
    class TipoDado
    {
        public void Mostrar()
        {
            bool completo = false;
            Console.WriteLine("Valor da variável boolean " + completo);

            char genero = 'F';
            Console.WriteLine("Valor da variável char: " + genero);

            char charunicode = '\u0041';
            Console.WriteLine("Valor da variável char: " + charunicode);

            sbyte x = 100;
            Console.WriteLine("Valor da variável sbyte: " + x);

            byte n1 = 126;
            Console.WriteLine("Valor da variável byte: " + n1);

            int n2 = 1000;
            Console.WriteLine("Valor da variável int: " + n2);

            int n3 = 2147483647;
            Console.WriteLine("Valor da variável int: " + n3);

            long n4 = 2147483648;
            Console.WriteLine("Valor da variável long: " + n4);  
            
            float n5 = 4.5f;
            Console.WriteLine("Valor da variável float: " + n5);  

            double n6 = 4.5;
            Console.WriteLine("Valor da variável double: " + n6);              

            /* Tipo .NET: System.String, imutável */
            string nome = "Maria Green"; 
            Console.WriteLine("Valor da variável string: " + nome);                          

            /* Tipo .NET: System.Object, objeto genérico */
            object obj1 = "Alex Brown";
            Console.WriteLine("Valor da variável object recebendo uma string: " + nome);                          
            
            /* Tipo .NET: System.Object, objeto genérico */
            object obj2 = 4.5f;
            Console.WriteLine("Valor da variável object recebendo um float: " + nome);    

            int n7 = int.MinValue;
            System.Console.WriteLine("Valor mínimo para inteiro: " + n7);

            long n8 = long.MaxValue;
            System.Console.WriteLine("Valor máximo para long: " + n8);
        }
    }
}

