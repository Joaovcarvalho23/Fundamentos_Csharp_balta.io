﻿using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();

            // decimal valor = 10.25m;
            // Console.WriteLine(valor);

        // ***************** FORMATANDO MOEDAS *****************
            decimal valor = 10.25m;
            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")));
        } //temos o "G", "E", "F"...
    }
}