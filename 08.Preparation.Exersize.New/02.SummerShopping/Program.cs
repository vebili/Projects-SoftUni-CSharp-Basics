using System;

namespace _02.SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double beachTowelPrice = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double umbrellaPrice = 2.0 / 3 * beachTowelPrice;
            double flipFlopsPrice = 0.75 * umbrellaPrice;
            double bagPrice = 1.0 / 3 * (beachTowelPrice + flipFlopsPrice);

            double total = beachTowelPrice + umbrellaPrice + flipFlopsPrice + bagPrice;

            total -= discount / 100.00 * total;
            if (budget >= total)
            {
                Console.WriteLine($"Annie's sum is {total:f2} lv. She has {budget - total:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {total:f2} lv. She needs {total- budget:f2} lv. more.");
            }

        }
    }
}
