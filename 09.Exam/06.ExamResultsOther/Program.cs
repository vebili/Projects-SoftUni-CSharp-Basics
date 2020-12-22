using System;

namespace _06.ExamResultsOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            string nameStudent;
            int points = 0;
            double pointsCounter = 0;
            double evaluation = 0;
            bool chek = false;

            while (result != "Midnight")
            {
                nameStudent = Console.ReadLine();
                chek = false;
                pointsCounter = 0;
                if (nameStudent == "Midnight")
                {
                    return;
                }
                for (int i = 1; i <= 6; i++)
                {
                    points = int.Parse(Console.ReadLine());

                    if (points < 0)
                    {
                        Console.WriteLine($"{nameStudent} was cheating!");
                        chek = true;
                        break;
                    }
                    pointsCounter += points;
                }
                if (chek)
                {
                    continue;
                }
                evaluation = Math.Floor(pointsCounter / 600 * 100);

                evaluation *= 0.06;

                if (evaluation < 3)
                {
                    evaluation = 2;
                }
                if (evaluation >= 5)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("|   CERTIFICATE   |");
                    Console.WriteLine($"|    {evaluation:f2}/6.00    |");
                    Console.WriteLine("===================");
                    Console.WriteLine($"Issued to {nameStudent}");
                }
                else
                {
                    Console.WriteLine($"{nameStudent} - {evaluation:f2}");
                }
            }
        }
    }
}
