namespace Datas
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();
            
            //var data = new DateTime(2023, 08, 25, 8, 12, 30);
            var data = DateTime.Now;

            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
        }
    }
}