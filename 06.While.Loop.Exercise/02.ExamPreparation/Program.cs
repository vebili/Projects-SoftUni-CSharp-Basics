using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());

            int failedCount = 0;
            int solvedCount = 0;
            double gradeSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (failedCount < failedThreshold)
            {
                string problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedCount++;
                }
                gradeSum += grade;
                solvedCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum / solvedCount:f2}");
                Console.WriteLine($"Number of problems: {solvedCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
