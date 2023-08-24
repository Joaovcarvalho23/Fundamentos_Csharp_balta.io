using System.Text.RegularExpressions;

namespace EditorHTML
{
    public static class Visualizador{

        public static void Show(string texto){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZADOR");
            Console.WriteLine("-------------------------");
            Replace(texto);
            Console.WriteLine("-------------------------");
            Console.ReadKey();
            Menu.Mostrar();
        }

        public static void Replace(string texto){
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras = texto.Split(' ');

            for(var i = 0; i < palavras.Length; i++){
                if(strong.IsMatch(palavras[i])){
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(
                        palavras[i].Substring(
                            palavras[i].IndexOf('>') + 1,
                            (
                                (palavras[i].LastIndexOf('<') - 1) - palavras[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                } else{
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}