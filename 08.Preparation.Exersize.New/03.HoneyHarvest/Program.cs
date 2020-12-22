using System;

namespace _03.HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string["Sunflower", "Daisy", "Lavender", "Mint"].
            //•	На втори ред получавате брой цветя: цяло число[1 - 1000].
            //•	На трети ред получавате сезон: string["Spring", "Summer", "Autumn"].
            string flower = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            //Season Sunflower   Daisy Lavender  Mint
            //Spring      10      12     12       10
            //Summer      8       8      8        12
            //Autumn      12      6      6         6

            double gathered = 0.00;

            switch (season)
            {
                case "Spring":
                    switch (flower)
                    {
                        case "Sunflower":
                            gathered = 10 * num;
                            break;
                        case "Daisy":
                            gathered = 12 * num;
                            gathered += gathered * 0.10;
                            break;
                        case "Lavender":
                            gathered = 12 * num;
                            break;
                        case "Mint":
                            gathered = 10 * num;
                            gathered += gathered * 0.10;
                            break;
                    }
                    break;
                case "Summer":
                    switch (flower)
                    {
                        case "Sunflower":
                            gathered = 8 * num;
                            gathered += gathered * 0.10;
                            break;
                        case "Daisy":
                            gathered = 8 * num;
                            gathered += gathered * 0.10;
                            break;
                        case "Lavender":
                            gathered = 8 * num;
                            gathered += gathered * 0.10;
                            break;
                        case "Mint":
                            gathered = 12 * num;
                            gathered += gathered * 0.10;
                            break;
                    }
                    break;
                case "Autumn":
                    switch (flower)
                    {
                        case "Sunflower":
                            gathered = 12 * num;
                            gathered -= gathered * 0.05;
                            break;
                        case "Daisy":
                            gathered = 6 * num;
                            gathered -= gathered * 0.05;
                            break;
                        case "Lavender":
                            gathered = 6 * num;
                            gathered -= gathered * 0.05;
                            break;
                        case "Mint":
                            gathered = 6 * num;
                            gathered -= gathered * 0.05;
                            break;
                    }
                    break;
            }
            
                Console.WriteLine($"Total honey harvested: {gathered:f2}");
        }
    }
}
