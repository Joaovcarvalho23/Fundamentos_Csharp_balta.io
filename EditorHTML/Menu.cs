namespace EditorHTML
{
    public static class Menu{

        public static void Mostrar(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue; //cor do fundo
            Console.ForegroundColor = ConsoleColor.Black; //cor da letra

            //EscreverOpcoes();
            DesenharTela();
            EscreverOpcoes();

            var opcao = short.Parse(Console.ReadLine());
        }

        public static void DesenharTela(){

            Console.Write("+");
            for (int i = 0; i <= 30; i++){
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for(int j = 0; j <= 10; j++){
                Console.Write("|");

                for(int i = 0; i <= 30; i++){
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++){
                Console.Write("-");
            }
            Console.Write("+");

        }
    
        public static void EscreverOpcoes(){
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("===================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.WriteLine("Opção: ");
            Console.SetCursorPosition(10,10);
        }
    }
}