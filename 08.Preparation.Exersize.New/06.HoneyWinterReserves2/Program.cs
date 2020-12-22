using System;

namespace _06.HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantity = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            while (name != "Winter has come")
            {
                double total = 0;

                for (int i = 1; i <= 6; i++)
                {
                    double collectedHoney = double.Parse(Console.ReadLine());
                    total += collectedHoney;
                }
                if (total < 0)
                {
                    Console.WriteLine($"{name} was banished for gluttony");
                }

                quantity -= total;
                if (quantity <= 0)
                {
                    break;
                }
                name = Console.ReadLine();
            }

            if (quantity > 0)
            {
                Console.WriteLine($"Hard Winter! Honey needed {quantity:F2}.");
            }
            else
            {
                Console.WriteLine($"Well done! Honey surplus {Math.Abs(quantity):F2}.");
            }
        }
    }
}