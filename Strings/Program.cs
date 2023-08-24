namespace Strings
{
    class Program
    {
        static void Main(string[] args){

            Console.Clear();
            var id = Guid.NewGuid(); //estamos criando um identificador global único!
            id.ToString(); //Transformando ele em uma String

            id = new Guid("7567388b-f08a-4d3e-83c6-a050b58b6a62");// podemos passar uma String para ele
            
            //pode comparar um guid com outro
            //if(id == Guid.NewGuid())
            
            Console.WriteLine(id.ToString().Substring(0, 8)); //Pega os 8 primeiros caracteres da string
        }
    }
}