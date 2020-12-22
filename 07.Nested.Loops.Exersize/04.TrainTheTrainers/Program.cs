using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            double allScore = 0;
            double counter = 0;

            while (true)
            {
                string nameOfPresentation = Console.ReadLine();
                double sumOfGrades = 0;

                if (nameOfPresentation == "Finish")
                {
                    double scoreSum = allScore / counter;
                    Console.WriteLine($"Student's final assessment is {scoreSum:f2}.");
                    break;
                }
                for (int i = 0; i < numOfPeople; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    allScore += grade;
                    counter++;
                }
                double sumAverage = sumOfGrades / numOfPeople;
                Console.WriteLine($"{nameOfPresentation} - {sumAverage:f2}.");

            }
        }
    }
}
