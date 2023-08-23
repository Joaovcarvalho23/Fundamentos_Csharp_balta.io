// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program{
        static void Main(string[] args){
            // Soma();
            // Subtracao();
           // Divisao();
            Multiplicacao();
        }

        static void Soma(){
            Console.Clear();
            Console.WriteLine("\nPrimeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine("\nO resultado da soma é {0}", soma);
            //Console.WriteLine($"O resultado da soma é {soma2}");
            Console.ReadKey();
        }

        static void Subtracao(){
            Console.Clear();
            Console.WriteLine("\nPrimeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int subtracao = valor1 - valor2;

            Console.WriteLine("\nO resultado da subtração é {0}", subtracao);
            Console.ReadKey();
        }

        static void Divisao(){
            Console.Clear();
            Console.WriteLine("\nPrimeiro valor: ");
            var valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var valor2 = float.Parse(Console.ReadLine());

            float divisao = (float)Math.Round(valor1 / valor2, 2);
            Console.WriteLine("\nO valor da divisão é {0}", divisao);
            Console.ReadKey();
        }

        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("\nPrimeiro valor: ");
            var valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            var valor2 = int.Parse(Console.ReadLine());

            int multiplicacao = valor1 * valor2;
            Console.WriteLine("\nO resultado da multiplicação é {0}", multiplicacao);
            Console.ReadKey();
        }
    }    
}