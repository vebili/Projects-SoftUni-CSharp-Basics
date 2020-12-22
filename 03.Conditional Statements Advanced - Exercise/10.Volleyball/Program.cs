using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double days = 0;
            days += h;
            double normalWeekendPlays = ((48 - h) / 4.00) * 3;
            days += normalWeekendPlays;
            double holidayPlays = (p / 3.00) * 2;
            days += holidayPlays;
            if (leap == "leap")
            {
                days += (days / 100.00) * 15;
            }
            Console.WriteLine(Math.Floor(days));
        }
    }
}
