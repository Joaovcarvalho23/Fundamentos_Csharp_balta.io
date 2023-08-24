namespace compara_String
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            //var texto = "testando...";
            // Console.WriteLine(texto.CompareTo("testando..."));
            // Console.WriteLine(texto.CompareTo("Testando..."));
            
            var texto = "Esse texto é um teste";
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); //"ignore o case sensitive
        }
    }
}