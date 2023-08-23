namespace Cronometro{
    class Program{
        static void Main(string[] args){
           // Start(8);
           Menu();
        }

        static void Menu(){
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
        }

        static void Start(int tempo){
            int tempoAtual = 0;

            while(tempoAtual != tempo){
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finzalizado!");
            Thread.Sleep(2500);
        }
        
    }
}