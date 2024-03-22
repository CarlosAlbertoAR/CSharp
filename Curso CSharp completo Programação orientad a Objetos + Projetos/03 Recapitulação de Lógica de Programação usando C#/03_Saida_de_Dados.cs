using System;
using System.Globalization;

/* Saída de dados */

char genero = 'F';
int idade = 32;
double saldo = 10.35784;
string nome = "Maria";

/* Impressão na saída padrão (console) */

    Console.WriteLine("Bom dia!");
    Console.WriteLine("Boa tarde!");

    Console.Write("Bom dia!");
    Console.Write("Boa tarde!");

    Console.WriteLine("");
        
/* Impressão de campo Double com 2 casas decimais*/    

    Console.WriteLine("Double arredondado a 2 cadas decimais" + saldo.ToString("F2"));

/* Impressão de campo Double com 4 casas decimais e trocando virgula por ponto. */

Console.WriteLine("Double arredondado a 2 cadas decimais" + saldo.ToString("F4"));

/* Impressão de campo Double com controle de casas decimais e trocando virgula por ponto. */

Console.WriteLine("Double arredondado a 2 cadas decimais" + saldo.ToString("F4", CultureInfo.InvariantCulture));

/* Format - Placeholders, concatenação e interpolação */

/* Placeholder */
Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade,saldo);

/* interpolação */
Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

/* Concatenação */
Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");


