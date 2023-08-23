// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program{
        static void Main(string[] args){

           EscolheOperacao();
           
        }

        static void EscolheOperacao(){
            Console.Clear();
            Console.WriteLine("\n\n##CALCULADORA##");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.Write("Informe a operação que deseja fazer: ");

            var escolhaUsuario = int.Parse(Console.ReadLine());

            switch(escolhaUsuario){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: return;
                default: Console.WriteLine("Por favor, informe um número correto.");
                        Console.ReadKey();
                        EscolheOperacao();
                        break;
            }
        }

        static void Soma(){
            Console.WriteLine("\nPrimeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine("O resultado da soma é {0}", soma);
            //Console.WriteLine($"O resultado da soma é {soma2}");
            Console.ReadKey();
            EscolheOperacao();
        }

        static void Subtracao(){
            Console.WriteLine("\nPrimeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int subtracao = valor1 - valor2;

            Console.WriteLine("O resultado da subtração é {0}", subtracao);
            Console.ReadKey();
            EscolheOperacao();
        }

        static void Divisao(){
            Console.WriteLine("\nPrimeiro valor: ");
            var valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var valor2 = float.Parse(Console.ReadLine());

            float divisao = (float)Math.Round(valor1 / valor2, 2);
            Console.WriteLine("O valor da divisão é {0}", divisao);
            Console.ReadKey();
            EscolheOperacao();
        }

        static void Multiplicacao(){
            Console.WriteLine("\nPrimeiro valor: ");
            var valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var valor2 = int.Parse(Console.ReadLine());

            int multiplicacao = valor1 * valor2;
            Console.WriteLine("O resultado da multiplicação é {0}", multiplicacao);
            Console.ReadKey();
            EscolheOperacao();
        }
    }    
}