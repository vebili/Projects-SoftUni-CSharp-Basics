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

            while (true)
            {
                bees -= bearAttack;
                if (bees >= 100)
                {
                    bearHealth -= bees * 5;

                }
                else if (bees < 100)
                {
                    if (bees >= 0)
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left 0.");
                        break;
                    }
                }
                if (bearHealth <= 0)
                {
                    Console.WriteLine($"Beehive won! Bees left {bees}.");
                    break;
                }


            }

        }
    }
}
