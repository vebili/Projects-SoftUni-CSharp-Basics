using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine()); //!!!- double

                double save = double.Parse(Console.ReadLine());
                double savedTotal = save;

                while (savedTotal < budget)
                {
                    save = double.Parse(Console.ReadLine());
                    savedTotal += save;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
