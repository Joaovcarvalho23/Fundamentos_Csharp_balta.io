namespace Cronometro{
    class Program{
        static void Main(string[] args){
           // Start(8);
           Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dado = Console.ReadLine().ToLower();
            char type = char.Parse(dado.Substring(dado.Length - 1, 1));
            Console.WriteLine(dado);
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