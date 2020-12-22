using System;

namespace _06.BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totalSold = 0;
            double totalMoney = 0;

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();

                int cakesCount = 0;
                int waffelsCount = 0;
                int cookiesCount = 0;

                string input = Console.ReadLine();

                while (input != "Stop baking!")
                {
                    int num = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case "cookies":
                            cookiesCount += num;
                            break;
                        case "waffles":
                            waffelsCount += num;
                            break;
                        case "cakes":
                            cakesCount += num;
                            break;
                    }

                    input = Console.ReadLine();
                }

                totalSold += cakesCount + cookiesCount + waffelsCount;
                totalMoney += cakesCount * 7.80 + cookiesCount * 1.50 + waffelsCount * 2.30;

                Console.WriteLine($"{name} baked {cookiesCount} cookies, {cakesCount} cakes and {waffelsCount} waffles.");

            }
            Console.WriteLine($"All bakery sold: {totalSold}");
            Console.WriteLine($"Total sum for charity: {totalMoney:f2} lv.");

        }
    }
}
