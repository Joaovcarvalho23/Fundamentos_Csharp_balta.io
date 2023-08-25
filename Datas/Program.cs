﻿namespace Datas
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
        // ******************** VALORES DAS DATAS ********************
            //var data = new DateTime(2023, 08, 25, 8, 12, 30);
            // var data = DateTime.Now;

            // Console.WriteLine(data);
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.Hour);
            // Console.WriteLine(data.Minute);
            // Console.WriteLine(data.Second);
            // Console.WriteLine(data.DayOfWeek);
            // Console.WriteLine(data.DayOfYear);

        // ******************** FORMATANDO DATAS ********************
            // var data = DateTime.Now;
            // var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            // Console.WriteLine(formatada);

        // ******************** PADRÕES DE FORMATAÇÃO ********************
            var data = DateTime.Now;
            var formatada = String.Format("{0:D}", data);
            // var formatada = String.Format("{0:y}", data);
            // var formatada = String.Format("{0:t}", data);
            // var formatada = String.Format("{0:r}", data);
            // var formatada = String.Format("{0:s}", data); //Mais usada com JSON
            Console.WriteLine(formatada);
        }
    }
}