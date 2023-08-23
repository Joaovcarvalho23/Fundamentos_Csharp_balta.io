// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program{
        static void Main(string[] args){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;
            int soma2 = valor1 + valor2;

            Console.WriteLine("O resultado da soma é {0}", soma);
            Console.WriteLine($"O resultado da soma é {soma2}");
        }
    }    
}