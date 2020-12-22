using System;

namespace _02.Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int countWalk = int.Parse(Console.ReadLine());
            int callories = int.Parse(Console.ReadLine());

            double allWalking = countWalk * minutesWalk;
            double allBurn = allWalking * 5;

            if (allBurn >= (callories * 0.5))
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {allBurn}.");
            }
            else if (allBurn < (callories * 0.5))
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {allBurn}.");
            }

        }
    }
}
