// See https://aka.ms/new-console-template for more information

// A importação dos 'namespaces' é feita através do Using!!
// Essas importações definem quais bibliotecas o nosso programa vai usar;
// Isso é feito no começo do programa

using System.Globalization;

namespace Fundamentos_Csharp
{
    class Program{
        static void Main (string[] args){

            // var texto = "Testando";
            // Console.WriteLine(texto);

            // string? teste;
            // Console.WriteLine("Digite seu nome: ");
            // teste = Console.ReadLine();
            // Console.WriteLine("Seu nome é {0}", teste);

            /********************** CONVERTENDO TIPOS **********************/
            int inteiro = 100;
            float real = 25.5f;

            //real = inteiro; //100.0f    //inteiro = real; dá erro!
            
            //inteiro = (int)real; //conversão explícita
            
            //inteiro = int.Parse(real.ToString()); //.Parse() só para strings!!
           
            /*
            string valorReal = real.ToString();
            inteiro = (int)float.Parse(valorReal);
            */
            
            inteiro = Convert.ToInt32(real);

            //inteiro = int.Parse("255");

            //Console.WriteLine(valorReal);
            Console.WriteLine(inteiro);
            Console.WriteLine(Convert.ToBoolean(1));
            Console.WriteLine(Convert.ToBoolean(0));
        }
    }
}