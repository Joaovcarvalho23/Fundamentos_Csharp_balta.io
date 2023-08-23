namespace Cronometro{
    class Program{
        static void Main(string[] args){
            //Console.WriteLine("Hello, World!");
            Start();
        }

        static void Start(){
            int tempo = 10;
            int tempoAtual = 0;

            while(tempoAtual != tempo){
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
        }
        
    }
}