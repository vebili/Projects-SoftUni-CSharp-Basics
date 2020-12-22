using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numMen = int.Parse(Console.ReadLine());

            double rentPrice = 0.0;
            
            switch (season)
            {
                case "Spring":
                    rentPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rentPrice = 4200;
                    break;
                case "Winter":
                    rentPrice = 2600;
                    break;
            }

            if (numMen <= 6)
            {
                rentPrice -= rentPrice * 0.1;
            }
            else if (numMen >= 7 && numMen <= 11)
            {
                rentPrice -= rentPrice * 0.15;
            }
            else if (numMen > 12)
            {
                rentPrice -= rentPrice * 0.25;
            }

            if (season != "Autumn" && numMen % 2 == 0)
            {
                rentPrice -= rentPrice * 0.05;
            }


            double diff = Math.Abs(rentPrice - budget);

            if (rentPrice > budget)
            {
                Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
            }
            else if (budget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {diff:f2} leva left.");
            }
        }
    }
}
