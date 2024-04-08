using System;
using TiposDeDados;
using Convensoes;
using SaidaDeDados;
using ExercicioSaidaDeDaos;
using OperadoresDeAtribuicao;

namespace Main
{
    class Core
    {
        static void Main()
        {
            TipoDado Tipos = new TipoDado();
            Tipos.Mostrar(); 

            SaidaDados Saida = new SaidaDados();
            Saida.Mostrar();

            OperadoresAtribuicao Operadores = new OperadoresAtribuicao();
            Operadores.Mostrar();

            System.Console.ReadLine();
        }
    }        
}

