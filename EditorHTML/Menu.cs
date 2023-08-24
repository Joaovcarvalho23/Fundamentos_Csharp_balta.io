namespace EditorHTML
{
    public static class Menu{

        public static void Mostrar(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue; //cor do fundo
            Console.ForegroundColor = ConsoleColor.Black; //cor da letra

            DesenharTela();
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
    }
}