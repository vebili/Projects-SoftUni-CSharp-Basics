using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double moneySpent = 0.00;
            string destinationResult = "";
            if (budget <= 100)
            {
                destinationResult = "Bulgaria";
                if (season == "summer")
                {
                    moneySpent = 0.30 * budget;
                    Console.WriteLine($"Somewhere in {destinationResult}");
                    Console.WriteLine($"Camp - {moneySpent:F2}");
                }
                else if (season == "winter")
                {
                    moneySpent = 0.70 * budget;
                    Console.WriteLine($"Somewhere in {destinationResult}");
                    Console.WriteLine($"Hotel - {moneySpent:F2}");
                }


            }
            else if (budget <= 1000)
            {
                destinationResult = "Balkans";
                if (season == "winter")
                {
                    moneySpent = 0.80 * budget;
                    Console.WriteLine($"Somewhere in {destinationResult}");
                    Console.WriteLine($"Hotel - {moneySpent:F2}");
                }
                else if (season == "summer")
                {
                    moneySpent = 0.40 * budget;
                    Console.WriteLine($"Somewhere in {destinationResult}");
                    Console.WriteLine($"Camp - {moneySpent:F2}");
                }
            }
            else
            {
                destinationResult = "Europe";
                moneySpent = 0.90 * budget;
                Console.WriteLine($"Somewhere in {destinationResult}");
                Console.WriteLine($"Hotel - {moneySpent:F2}");
            }

        }
    }
}
