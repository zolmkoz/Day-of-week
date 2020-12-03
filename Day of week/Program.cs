using System;
using System.Globalization; //vung thoi gian

namespace Day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dataAsText, "d-M-yyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
