namespace Arrays
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            
            // // var meuArray = new int[5] {1, 23, 15, 27, 75};
            // // meuArray[0] = 12;
            // var meuArray = new Teste[2];
            // meuArray[0] = new Teste();

            // Console.WriteLine(meuArray[0].Id);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);

        // ******************* PERCORRENDO ARRAY *******************
            // var meuArray = new int[5] {1, 2, 3, 4, 5};
            // meuArray[0] = 12;

            // for (var i = 0; i < meuArray.Length; i++){
            //     Console.WriteLine(meuArray[i]);
            // }

        // ******************* FOREACH *******************
            //  var meuArray = new int[5] {1, 2, 3, 4, 5};
            //  meuArray[0] = 12;

            //  var funcionarios = new Funcionario[5];
            //  funcionarios[0] = new Funcionario() {Id = 2307, Nome =  }

            // foreach (var funcionario in funcionarios)
            // {
            //     Console.WriteLine(funcionario.Id);
            // }

        // ******************* ALTERANDO VALORES *******************
            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];
            primeiro.CopyTo(segundo, 0);

            primeiro[0] = 23;
            Console.WriteLine(segundo[0]);
        }

        //public struct Funcionario{
            //public int Id {get; set;}

          //  public string Nome {get; set;}
        //}

        // struct Teste{
        //     public int Id {get; set;}
        // }
    }
}