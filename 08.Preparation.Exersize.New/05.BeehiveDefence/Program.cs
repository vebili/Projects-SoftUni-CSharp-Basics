using System;

namespace _05.BeehiveDefence
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int bearHealth = int.Parse(Console.ReadLine());
            int bearAttack = int.Parse(Console.ReadLine());
            int counter = 1;
            while (true)
            {

                bees -= bearAttack;
                bearHealth -= bees * 5;
                counter++;

                if (bearHealth <= 0)
                {
                    Console.WriteLine($"Beehive won! Bees left {bees}.");
                    break;
                }
                if (bees <= 100 && bees >= 0)
                {
                    Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
                    break;
                }
                if (bees < 0)
                {
                    Console.WriteLine($"The bear stole the honey! Bees left {0}.");
                    break;
                }
            }
        }
    }
}
