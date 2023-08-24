namespace TopicosString
{
    class Program
    {
        static void Main (string[] args){
            
        // ***************** EQUALS *****************
            // Console.Clear();
            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.Equals("Este texto é um teste"));
            // Console.WriteLine(texto.Equals("este texto é um teste"));
            // Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));

        // ***************** ÍNDICES *****************
            Console.Clear();
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.IndexOf("um"));

            Console.WriteLine(texto.LastIndexOf("s"));
        }
    }
}