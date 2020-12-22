using System;

namespace _04.DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPoints = int.Parse(Console.ReadLine());
            int counter = 0;
            while (true)
            {
                string sector = Console.ReadLine();
                counter++;
                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {counter} moves!");
                    break;
                }
                int points = int.Parse(Console.ReadLine());
                switch (sector)
                {
                    case "number section":
                        initialPoints -= points;
                        break;
                    case "double ring":
                        initialPoints -= 2 * points;
                        break;
                    case "triple ring":
                        initialPoints -= 3 * points;
                        break;
                }
                if (initialPoints == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {counter} moves!");
                    break;
                }
                else if (initialPoints < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(initialPoints)}.");
                    break;
                }
            }

        }
    }
}
