// See https://aka.ms/new-console-template for more information

// A importação dos 'namespaces' é feita através do Using!!
// Essas importações definem quais bibliotecas o nosso programa vai usar;
// Isso é feito no começo do programa

using System.Globalization;

namespace Fundamentos_Csharp
{
    class Program{
        static void Main (string[] args){

            // var texto = "Testando";
            // Console.WriteLine(texto);

            // string? teste;
            // Console.WriteLine("Digite seu nome: ");
            // teste = Console.ReadLine();
            // Console.WriteLine("Seu nome é {0}", teste);

            /********************** CONVERTENDO TIPOS **********************/
            // int inteiro = 100;
            // float real = 25.5f;

            //real = inteiro; //100.0f    //inteiro = real; dá erro!
            
            //inteiro = (int)real; //conversão explícita
            
            //inteiro = int.Parse(real.ToString()); //.Parse() só para strings!!
           
            /*
            string valorReal = real.ToString();
            inteiro = (int)float.Parse(valorReal);
            */
            
            // inteiro = Convert.ToInt32(real);

            //inteiro = int.Parse("255");

            //Console.WriteLine(valorReal);
            // Console.WriteLine(inteiro);
            // Console.WriteLine(Convert.ToBoolean(1));
            // Console.WriteLine(Convert.ToBoolean(0));


            /********************** OPERADORES ARITMÉTICOS **********************/
            // double x = 2;
            // x = 75/23.8;

            // int x = 2;
            // x += 3;

            // Console.WriteLine(x);
            // Console.WriteLine(x == 25);


            /********************** USANDO IF **********************/
            // Mesma coisa das outras linguagens


            /********************** USANDO SWITCH **********************/
            // string valor = "André";
            // switch(valor){
            //     case "Joao": Console.WriteLine("Não é o cara."); break;
            //     case "Marcelo": Console.WriteLine("Não é o cara."); break;
            //     case "André": Console.WriteLine("É esse!!."); break;
            //     default: Console.WriteLine("Não achou ninguém :("); break;
            // }


            /********************** USANDO FOR **********************/
            // for(int i = 0; i <= 5; i++){
            //     Console.WriteLine(i);
            // }


            /********************** USANDO WHILE **********************/
            // var valor = 0;
            // while(valor <= 5){
            //     Console.WriteLine(valor);
            //     valor++;
            // }


            /********************** INVOCANDO FUNÇÃO **********************/
            // MeuMetodo();
            // string nome = RetornaNome("Joao Victor", "Carvalho", 22);
            // Console.WriteLine(nome);


            /********************** VALUE E REFERENCE TYPES **********************/
            //Tipo de valor.:
            // int x = 25;
            // int y = x;
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // x = 32;
            // Console.WriteLine(x);
            // Console.WriteLine(y);


            // //Tipo de referência
            // var array1 = new string[2];
            // array1[0] = "Item 1";
            // var array2 = array1;
            // Console.WriteLine(array1[0]);
            // Console.WriteLine(array2[0]);

            // array1[0] = "Item 2";
            // Console.WriteLine(array1[0]);
            // Console.WriteLine(array2[0]);


            /********************** CHAMANDO O STRUCT **********************/
            var mouse = new Produto(1, "Mouse Gamer", 299.97, ETipoDeProduto.Produto);
            var manutencaoEletrica = new Produto(2, "Manutenção elétrica", 120.00, ETipoDeProduto.Servico);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Nome);
            Console.WriteLine(mouse.Preco);
            Console.WriteLine(mouse.TipoProd);
            Console.WriteLine("Índice do Enum: {0}", (int)mouse.TipoProd);
            var mValorEmDolar = mouse.PrecoEmDolar(4.5);
            Console.WriteLine(mValorEmDolar+"\n");

            Console.WriteLine(manutencaoEletrica.Id);
            Console.WriteLine(manutencaoEletrica.Nome);
            Console.WriteLine(manutencaoEletrica.Preco);
            Console.WriteLine(manutencaoEletrica.TipoProd);
            Console.WriteLine("Índice do Enum: {0}", (int)manutencaoEletrica.TipoProd);
            var manValorEmDolar = manutencaoEletrica.PrecoEmDolar(4.5);
            Console.WriteLine(manValorEmDolar);

        }

        // static void MeuMetodo(){
        //     Console.WriteLine("C# é legal!");
        // }

        // static string RetornaNome(string nome, string sobrenome, int idade){
        //     return nome + " " + sobrenome + " tem " + idade.ToString();
        // }

    }

    struct Produto{
         //Atributos
        public int Id;
        public string Nome;
        public double Preco;
        public ETipoDeProduto TipoProd;


        //Construtor
        public Produto(int id, string nome, double preco, ETipoDeProduto tipoProd){
            Id = id;
            Nome = nome;
            Preco = preco;
            TipoProd = tipoProd;
        }


        //Métodos
        public double PrecoEmDolar(double dolar){
            return Preco * dolar;
        }
    }

    enum ETipoDeProduto{
        Produto = 1,
        Servico = 2
    }
}