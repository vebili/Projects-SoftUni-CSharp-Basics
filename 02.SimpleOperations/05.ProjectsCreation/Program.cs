using System;

namespace _05.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int numProj = int.Parse(Console.ReadLine());
            int sumHours = numProj * 3;
            Console.WriteLine($"The architect {archName} will need {sumHours} hours to complete {numProj} project/s.");
        }
    }
}
