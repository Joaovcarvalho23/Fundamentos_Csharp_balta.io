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
            char tipoDeTempo = char.Parse(dado.Substring(dado.Length - 1, 1));
            int tempo = int.Parse(dado.Substring(0, dado.Length - 1));
            
            int multiplicador = 1;
            if(tipoDeTempo == 'm')
                multiplicador = 60;
            

            if(tempo == 0)
                System.Environment.Exit(0);
            

            Start(tempo * multiplicador);

            // Console.WriteLine(tipoDeTempo);
            // Console.WriteLine(tempo);
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
            Menu();
        }
        
    }
}