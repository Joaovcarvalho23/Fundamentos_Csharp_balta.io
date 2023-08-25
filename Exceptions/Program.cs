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
            //  var meuArray = new int[3];

            //  try{
            //      for(var i = 0; i < 10; i++){
            //          //System.IndexOutOfRangeException
            //          Console.WriteLine(meuArray[i]);
            //      }

            //     //sempre do mais específico para o mais genérico
            //  } catch(IndexOutOfRangeException ex){

            //      Console.WriteLine("Não encontrei o índice na lista");
            //      Console.WriteLine(ex.Message);
            //      Console.WriteLine(ex.InnerException);

            //  } catch (Exception ex){ // esse sempre fica por último!!

            //      Console.WriteLine("Algo deu errado!");
            //      Console.WriteLine(ex.Message);
            //      Console.WriteLine(ex.InnerException);

            //  } 

        // ********************* DISPARANDO EXCESSÕES *********************]
            var meuArray = new int[3];

             try{
                //  for(var i = 0; i < 10; i++){
                //      //System.IndexOutOfRangeException
                //      Console.WriteLine(meuArray[i]);
                //  }

                 //Salvar("");
                 Salvar("fafwfwqfwf");

                //sempre do mais específico para o mais genérico
             } catch(IndexOutOfRangeException ex){

                 Console.WriteLine("Não encontrei o índice na lista");
                 Console.WriteLine(ex.Message);
                 Console.WriteLine(ex.InnerException);

             } catch (ArgumentNullException ex){ // esse sempre fica por último!!

                 Console.WriteLine("Falha ao cadastrar texto");
                 Console.WriteLine(ex.Message);
                 Console.WriteLine(ex.InnerException);

             } catch (MinhaException ex){
                 Console.WriteLine("Exceção customizada");
                 Console.WriteLine(ex.Message);
                 Console.WriteLine(ex.InnerException);
                 Console.WriteLine(ex.QuandoAconteceu);

             } catch (Exception ex){ // esse sempre fica por último!!

                 Console.WriteLine("Algo deu errado!");
                 Console.WriteLine(ex.Message);
                 Console.WriteLine(ex.InnerException);

             } finally{
                Console.WriteLine("Chegou ao fim!");
             }
        }

        private static void Salvar(string texto){

            if(string.IsNullOrEmpty(texto)){
                //throw new Exception("O texto não pode ser nulo ou vazio!");
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception{

            public MinhaException (DateTime data){
                QuandoAconteceu = data;
            }
            public DateTime QuandoAconteceu {get; set;}
        }
    }
}