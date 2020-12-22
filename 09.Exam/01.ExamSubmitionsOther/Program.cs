using System;

namespace _01.ExamSubmitionsOther
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int problems = int.Parse(Console.ReadLine());

            double solutions = 2.8;

            double totalSolutions = 0;
            double plusSolutions = 0;
            double finalSolutions = 0;
            double totalKb = 0;
            totalSolutions = students * Math.Ceiling(problems * solutions);

            plusSolutions = students * (problems / 3);
            finalSolutions = totalSolutions + plusSolutions;
            totalKb = 5 * Math.Ceiling(finalSolutions / 10);

            Console.WriteLine($"{totalKb} KB needed");
            Console.WriteLine($"{finalSolutions} submissions");
        }
    }
}
