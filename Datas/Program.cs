using System.Globalization;

namespace Datas
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
           // var data = DateTime.Now;
           // var formatada = String.Format("{0:D}", data);
            // var formatada = String.Format("{0:y}", data);
            // var formatada = String.Format("{0:t}", data);
            // var formatada = String.Format("{0:r}", data);
            // var formatada = String.Format("{0:s}", data); //Mais usada com JSON
          //  Console.WriteLine(formatada);

        // ******************** ADICIONANDO VALORES ********************
            // var data  = DateTime.Now;
            // Console.WriteLine(data);
            // Console.WriteLine(data.AddDays(10));
            // Console.WriteLine(data.AddMonths(2));
            // Console.WriteLine(data.AddYears(3));

        // ******************** COMPARANDO DATAS ********************
            // //DateTime? data = null;
            // var data = DateTime.Now;

            // // if(data == DateTime.Now){
            // //     Console.WriteLine("É igual");
            // // } NUNCA VAI FUNCIONAR POR CAUSA DA FRAÇÃO DE SEGUNDOS

            // if(data.Date == DateTime.Now.Date)
            //     Console.WriteLine("É igual");

            // Console.WriteLine(data);

        // ******************** CULTUREINFO ********************
            // var dataEmPortugues = new CultureInfo("pt-BR");
            // var dataEmPortugal = new CultureInfo("pt-PT");
            // var dataEmIngles = new CultureInfo("en-US");
            // var dataEmDinamarca = new CultureInfo("de-DE");

            // Console.WriteLine(DateTime.Now.ToString("D", dataEmPortugues));
            // Console.WriteLine(DateTime.Now.ToString("D", dataEmPortugal));
            // Console.WriteLine(DateTime.Now.ToString("D", dataEmIngles));
            // Console.WriteLine(DateTime.Now.ToString("D", dataEmDinamarca));

        // ******************** TIMEZONE ********************
            // //Para operar em servidores com outras linguas, tipo portugues, ingles, espanhol...
            // var utcDate = DateTime.UtcNow; //usar se estiver trabalhando com aplicações globalizadas

            // Console.WriteLine(DateTime.Now);
            // Console.WriteLine(utcDate);
            // Console.WriteLine(utcDate.ToLocalTime()); //cultureinfo
            // Console.WriteLine(" ");

            // //Se a máquina está nos EUA, mas meu usuário está na Austrália... como fazemos para colocar um timezone nessa máquina?
            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // Console.WriteLine(timezoneAustralia);
            // Console.WriteLine(" ");

            // var horasAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            // Console.WriteLine(horasAustralia);
            // Console.WriteLine(" ");

            // //Pegar todos os timezones que estão armazenados no sistema
            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia));
            //     Console.WriteLine("-----------------");
            // }

        // ******************** TIMESPAN ********************
            // var tipeSpan = new TimeSpan();
            // Console.WriteLine(tipeSpan);

            // var tipeSpanNanoSegundos = new TimeSpan(1);
            // Console.WriteLine(tipeSpanNanoSegundos);

            // var tipeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            // Console.WriteLine(tipeSpanHoraMinutoSegundo);

            //  var tipeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 12, 8);
            // Console.WriteLine(tipeSpanDiaHoraMinutoSegundo);

            //  var tipeSpanHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 8, 100);
            // Console.WriteLine(tipeSpanHoraMinutoSegundoMilissegundo);

        // ******************** REVISÃO ********************
            Console.WriteLine(DateTime.DaysInMonth(2023, 2));
            Console.WriteLine(FimDeSemana(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); //horário de verão que retorna um boolean

        }

        static bool FimDeSemana(DayOfWeek hoje){
            return hoje == DayOfWeek.Saturday || hoje == DayOfWeek.Friday;
        }
    }
}