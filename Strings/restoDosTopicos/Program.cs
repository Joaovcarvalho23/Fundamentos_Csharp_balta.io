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
            // Console.Clear();
            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.IndexOf("é"));
            // Console.WriteLine(texto.IndexOf("um"));

            // Console.WriteLine(texto.LastIndexOf("s"));

        // ***************** MÉTODOS ADICIONAIS *****************
            Console.Clear();
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.Insert(5, "AQUI "));
            Console.WriteLine(texto.Remove(5, 5));
            Console.WriteLine(texto.Length);
        }
    }
}