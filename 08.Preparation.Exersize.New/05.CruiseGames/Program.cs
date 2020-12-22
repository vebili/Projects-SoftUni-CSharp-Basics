using System;

namespace _05.CruiseGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numGames = int.Parse(Console.ReadLine());
            int volleyballGames = 0;
            double volleyballPoints = 0;
            int tennisGames = 0;
            double tennisPoints = 0;
            int badmintoGames = 0;
            double badmintoPoints = 0;

            for (int i = 1; i <= numGames; i++)
            {
                string game = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());
                switch (game)
                {
                    case "volleyball":
                        volleyballGames++;
                        volleyballPoints += points + points * 0.07;
                        break;
                    case "tennis":
                        tennisGames++;
                        tennisPoints += points + points * 0.05;
                        break;
                    case "badminton":
                        badmintoGames++;
                        badmintoPoints += points + points * 0.02;
                        break;
                }
            }
            double volleyballAveragePoints = volleyballPoints / volleyballGames;
            double tennisAveragePoints = tennisPoints / tennisGames;
            double badmintonAveragePoints = badmintoPoints / badmintoGames;

            double totalPoints = Math.Floor(volleyballPoints + tennisPoints + badmintoPoints);

            if (volleyballAveragePoints >= 75 && tennisAveragePoints >= 75 && badmintonAveragePoints >= 75)
            {
                Console.WriteLine($"Congratulations, {name}! You won the cruise games with {totalPoints} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {totalPoints}.");
            }
        }
    }
}
