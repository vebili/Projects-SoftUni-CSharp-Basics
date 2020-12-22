using System;

namespace _05._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int problems = int.Parse(Console.ReadLine());
            int energyTrainer = int.Parse(Console.ReadLine());
            int questions = 0;
            int totalSolved = 0;
            int totalQuestions = 0;
            while (true)
            {
                energyTrainer += 2 * problems;
                students -= problems;
                questions = students * 2;
                energyTrainer -= 3 * questions;
                totalSolved += problems;
                totalQuestions += questions;

                if (students < 10)
                {
                    Console.WriteLine($"The students are too few!");
                    Console.WriteLine($"Problems solved: {totalSolved}");
                    break;
                }
                if (students / 10 != 0)
                {
                    students++;
                }
                if (energyTrainer <= 0)
                {
                    Console.WriteLine($"The trainer is too tired!");
                    Console.WriteLine($"Questions asked: {totalQuestions}");
                    break;
                }
            }
        }
    }
}
