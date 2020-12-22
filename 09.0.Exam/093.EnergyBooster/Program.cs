using System;

namespace _03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sets = Console.ReadLine();
            double numberOfSets = double.Parse(Console.ReadLine());

            double price = 0;

            if (sets == "small")
            {
                if (fruit == "Watermelon")
                {
                    price = 2 * 56 * numberOfSets;
                }
                else if (fruit == "Mango")
                {
                    price = 2 * 36.66 * numberOfSets;

                }
                else if (fruit == "Pineapple")
                {
                    price = 2 * 42.10 * numberOfSets;
                }
                else if (fruit == "Raspberry")
                {
                    price = 2 * 20 * numberOfSets;
                }
            }
            if (sets == "big")
            {
                if (fruit == "Watermelon")
                {
                    price = 5 * 28.70 * numberOfSets;
                }
                else if (fruit == "Mango")
                {
                    price = 5 * 19.60 * numberOfSets;

                }
                else if (fruit == "Pineapple")
                {
                    price = 5 * 24.80 * numberOfSets;
                }
                else if (fruit == "Raspberry")
                {
                    price = 5 * 15.20 * numberOfSets;
                }
            }
            if (price >= 400 && price <= 1000)
            {

                Console.WriteLine($"{price - (price * 15 / 100):f2} lv.");
            }
            else if (price > 1000)
            {
                Console.WriteLine($"{price - (price * 50 / 100):f2} lv.");
            }
            else
            {
                Console.WriteLine($"{price:f2} lv.");
            }
        }
    }
}
