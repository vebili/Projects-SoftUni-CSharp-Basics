using System;

namespace _01._Exam_Submissions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int students = int.Parse(Console.ReadLine());
            int problems = int.Parse(Console.ReadLine());
            double solved = (students * Math.Ceiling(problems * 2.8));
            double allSolved = solved + (students * (problems / 3));                    

            double memory = 5 * (Math.Ceiling(allSolved / 10));
            
            Console.WriteLine($"{memory} KB needed");
            Console.WriteLine($"{allSolved} submissions");

        }
    }
}
