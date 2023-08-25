namespace Exceptions
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();

        // ********************* TRY CATCH *********************
            // var meuArray = new int[3];

            // try{
            //     for(var i = 0; i < 10; i++){
            //         //System.IndexOutOfRangeException
            //         Console.WriteLine(meuArray[i]);
            //     }
            // } catch (Exception ex){

            //     Console.WriteLine("Algo deu errado!");
            //     Console.WriteLine(ex.Message);
            //     Console.WriteLine(ex.InnerException);
            // }

        // ********************* TRATANDO ERROS *********************]
             var meuArray = new int[3];

             try{
                 for(var i = 0; i < 10; i++){
                     //System.IndexOutOfRangeException
                     Console.WriteLine(meuArray[i]);
                 }

                //sempre do mais específico para o mais genérico
             } catch(IndexOutOfRangeException ex){

                 Console.WriteLine("Não encontrei o índice na lista");
                 Console.WriteLine(ex.Message);
                 Console.WriteLine(ex.InnerException);

             } catch (Exception ex){ // esse sempre fica por último!!

                 Console.WriteLine("Algo deu errado!");
                 Console.WriteLine(ex.Message);
                 Console.WriteLine(ex.InnerException);

             } 

             
        }
    }
}