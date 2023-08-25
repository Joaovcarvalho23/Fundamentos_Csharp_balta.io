namespace Exceptions
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();

            var meuArray = new int[3];

            try{
                for(var i = 0; i < 10; i++){
                    //System.IndexOutOfRangeException
                    Console.WriteLine(meuArray[i]);
                }
            } catch (Exception ex){

                Console.WriteLine("Algo deu errado!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}