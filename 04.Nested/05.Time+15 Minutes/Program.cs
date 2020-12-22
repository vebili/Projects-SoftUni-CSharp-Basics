using System;

namespace _05.Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            
            int totalMins = (hour * 60) + mins + 15;
            int totalHour = totalMins / 60;
            if (totalHour == 24)
            {
                totalHour = 0;
                if (totalMins % 60 < 10)
                {
                    Console.WriteLine($"{totalHour}:0{totalMins % 60}");
                }
                else
                {
                    Console.WriteLine($"{totalHour}:{totalMins % 60}");
                }

            }
            else if (totalHour < 24) 
            { 
                if (totalMins % 60 < 10)
                {
                    Console.WriteLine($"{totalHour}:0{totalMins % 60}");
                }
                else
                {
                    Console.WriteLine($"{totalHour}:{totalMins % 60}");
                }
            }
        }
    }
}
