using System;

namespace _06.HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyNeeded = double.Parse(Console.ReadLine());

            string input = "";
            double honeySum = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Winter has come")
                {
                    break;
                }

                for (int i = 0; i < 6; i++)
                {
                    double honeyEarned = double.Parse(Console.ReadLine());
                    honeySum += honeyEarned;
                }

                if (honeySum < 0)
                {
                    Console.WriteLine($"{input} was banished for gluttony");
                    continue;
                }

                if (honeySum >= honeyNeeded)
                {
                    Console.WriteLine($"Well done! Honey surplus {honeySum - honeyNeeded:F2}.");
                    break;
                }

            }

            if (honeySum < honeyNeeded)
            {
                Console.WriteLine($"Hard Winter! Honey needed {honeyNeeded - honeySum:f2}.");
            }

        }
    }
}
