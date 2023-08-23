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
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string? path = Console.ReadLine();

            using (var file = new StreamReader(path)){
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }

        static void EditarArquivo(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)\n -----------------------------");
            string? texto = "";

            do{

                texto += Console.ReadLine();
                texto += Environment.NewLine;

            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            SalvarArquivo(texto);
        }

        static void SalvarArquivo(string texto){
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            //para abrir arquivo -> StreamReader | abrir arquivo para escrita -> StreamWriter
            // new StreamReader = abre arquivo || closing() {muito arriscado}

            using (var file = new StreamWriter(path)){ //ele abre e fecha o arquivo pra gente!
                file.Write(texto);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}