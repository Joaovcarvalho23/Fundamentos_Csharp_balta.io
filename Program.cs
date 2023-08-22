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
            // int inteiro = 100;
            // float real = 25.5f;

            //real = inteiro; //100.0f    //inteiro = real; dá erro!
            
            //inteiro = (int)real; //conversão explícita
            
            //inteiro = int.Parse(real.ToString()); //.Parse() só para strings!!
           
            /*
            string valorReal = real.ToString();
            inteiro = (int)float.Parse(valorReal);
            */
            
            // inteiro = Convert.ToInt32(real);

            //inteiro = int.Parse("255");

            //Console.WriteLine(valorReal);
            // Console.WriteLine(inteiro);
            // Console.WriteLine(Convert.ToBoolean(1));
            // Console.WriteLine(Convert.ToBoolean(0));


            /********************** OPERADORES ARITMÉTICOS **********************/
            // double x = 2;
            // x = 75/23.8;

            // int x = 2;
            // x += 3;

            // Console.WriteLine(x);
            // Console.WriteLine(x == 25);


            /********************** USANDO IF **********************/
            // Mesma coisa das outras linguagens


            /********************** USANDO SWITCH **********************/
            // string valor = "André";
            // switch(valor){
            //     case "Joao": Console.WriteLine("Não é o cara."); break;
            //     case "Marcelo": Console.WriteLine("Não é o cara."); break;
            //     case "André": Console.WriteLine("É esse!!."); break;
            //     default: Console.WriteLine("Não achou ninguém :("); break;
            // }


            /********************** USANDO FOR **********************/
            // for(int i = 0; i <= 5; i++){
            //     Console.WriteLine(i);
            // }


            /********************** USANDO WHILE **********************/
            var valor = 0;
            while(valor <= 5){
                Console.WriteLine(valor);
                valor++;
            }
        }
    }
}