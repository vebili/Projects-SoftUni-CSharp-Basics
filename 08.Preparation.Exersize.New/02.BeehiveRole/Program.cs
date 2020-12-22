using System;

namespace _02.BeehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            int intellect = int.Parse(Console.ReadLine());
            int force = int.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            bool queen = intellect >= 80 && force >= 80 && sex == "female";
            bool repairing = intellect >= 80;
            bool cleaning = intellect >= 60;
            bool drone = force >= 80 && sex == "male";
            bool guard = force >= 60;

            //Queen Bee >= 80 >= 80   female
            //Repairing Bee >= 80   Any Any
            //Cleaning Bee    >= 60   Any Any
            //Drone Bee   Any >= 80   male
            //Guard Bee Any >= 60   Any
            //Worker Bee Any Any Any
            if (queen)
            {
                Console.WriteLine("Queen Bee");
            }
            else if (repairing)
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (cleaning)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if (drone)
            {
                Console.WriteLine("Drone Bee");
            }
            else if (guard)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }
        }
    }
}
