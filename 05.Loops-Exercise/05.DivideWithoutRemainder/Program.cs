using System;

namespace _05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                //proverka za gr1
                if(value % 2 == 0)
                {
                    group1 += 1; //group1++;
                }
                //proverka za gr2
                if(value % 3 == 0)
                {
                    group2++;
                }
                if(value % 4 == 0)
                {
                    group3++;
                }
            }
            //znaem br chisla vav vsqka gr
            // % числа в гр1 или гр2 или гр3
            double percent1 = group1 * 1.0 / n * 100;
            double percent2 = group2 * 1.0 / n * 100;
            double percent3 = group3 * 1.0 / n * 100;
            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
        }
    }
}
