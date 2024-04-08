using System;
using System.Globalization;

namespace ExercicioSaidaDeDaos
{
    class ExercicioSaidaDados
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        public void Mostrar()
        {
            System.Console.WriteLine($"{produto1}, cujo preço é {preco1}");
            System.Console.WriteLine($"{produto2}, cujo preço é {preco2}");
            System.Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            System.Console.WriteLine("MEdida com oito casas decimais: " + medida.ToString("F8"));
            System.Console.WriteLine("Arrêdondado (Três casas decmais): " + medida.ToString("F3"));
            System.Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.ReadLine();
        }    
    }
}
