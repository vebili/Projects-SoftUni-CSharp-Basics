using System;

namespace _02.ExamPointsOther
{
    class Program
    {
        static void Main(string[] args)
        {
            int problem = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string course = Console.ReadLine();

            double coefficient = 0;

            if (course == "Basics")
            {
                if (problem == 1)
                {
                    coefficient = 8;
                }
                else if (problem == 2)
                {
                    coefficient = 9;
                }
                else if (problem == 3)
                {
                    coefficient = 9;
                }
                else if (problem == 4)
                {
                    coefficient = 10;
                }

            }
            else if (course == "Fundamentals")
            {
                if (problem == 1)
                {
                    coefficient = 11;
                }
                else if (problem == 2)
                {
                    coefficient = 11;
                }
                else if (problem == 3)
                {
                    coefficient = 12;
                }
                else if (problem == 4)
                {
                    coefficient = 13;
                }
            }
            else if (course == "Advanced")
            {
                if (problem == 1)
                {
                    coefficient = 14;
                }
                else if (problem == 2)
                {
                    coefficient = 14;
                }
                else if (problem == 3)
                {
                    coefficient = 15;
                }
                else if (problem == 4)
                {
                    coefficient = 16;
                }
            }
            double pointsTotal = (points * coefficient) / 100;
            if (course == "Advanced")
            {
                pointsTotal += pointsTotal * 0.20;
            }
            if (course == "Basics" && problem == 1)
            {
                pointsTotal -= pointsTotal * 0.20;
            }
            Console.WriteLine($"Total points: {pointsTotal:f2}");
        }
    }
}
