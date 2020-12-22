using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectPlunder = double.Parse(Console.ReadLine());
            double currentPlunder = 0;
            double thirdDayPlunder = dailyPlunder * 0.5;
            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0)
                {
                    currentPlunder += thirdDayPlunder + dailyPlunder;
                }
                else if (i % 5 == 0)
                {
                    currentPlunder += dailyPlunder;
                    currentPlunder -= currentPlunder * 0.30;
                }
                else
                {
                    currentPlunder += dailyPlunder;
                }
            }
            if (currentPlunder >= expectPlunder)
            {
                Console.WriteLine($"Ahoy! {currentPlunder:f2} plunder gained.");
            }
            //else
            //{
            //    double diff = currentPlunder / days;
            //    double diff2 = expectPlunder / days;
            //    double percentage = diff / diff2 * 100;
            //    Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            //}
            else
            {
                double diff = currentPlunder / days;
                double diff2 = expectPlunder / days;
                double percentage = diff / diff2 * 100;
                if (days == 0)
                {
                    percentage = 0;
                }
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
