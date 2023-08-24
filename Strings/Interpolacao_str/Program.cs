namespace Interp_Str
{
    class Program
    {
        static void Main(string[] args){

            Console.Clear();
            var preco = 10.2;
            //var texto = "O preço do produto é " + preco + " apenas na promoção!";
            //var texto = string.Format("O preço do produto é {0} apenas na promoção", preco);
            var texto = $"O preço do produto é {preco} apenas na promoção";
            Console.WriteLine(texto);
        }
    }
}