namespace Editor_de_Texto
{
    class Program
    {
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Selecione a opção desejada abaixo:");
            Console.WriteLine("1. ABRIR ARQUIVO");
            Console.WriteLine("2. CRIAR NOVO ARQUIVO");
            Console.WriteLine("0. SAIR");
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao){
                case 1: AbrirArquivo(); break;
                case 2: EditarArquivo(); break;
                case 0: System.Environment.Exit(0); break;
                default: ; break;
            }
        }

        static void AbrirArquivo(){

        }

        static void EditarArquivo(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)\n -----------------------------");
            string? texto = "";

            do{

                texto += Console.ReadLine();
                texto += Environment.NewLine;

            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(texto);
        }
    }
}