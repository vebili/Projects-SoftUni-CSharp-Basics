using System;

namespace _04._Exam_Retention
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = int.Parse(Console.ReadLine());
            double seasons = int.Parse(Console.ReadLine());
            double course1 = 0;
            double course2 = 0;
            double passed = 0;
            double overwrote = 0;
            
            for (int i = 1; i <= seasons; i++)
            {                
                course1 = Math.Ceiling(students * 1.0 * 90 / 100);                
                course2 = Math.Ceiling(course1 * 1.0 * 90 / 100);                
                passed = Math.Ceiling(course2 * 1.0 * 80 / 100);
                if (i % 3 == 0)
                {
                    overwrote = Math.Ceiling(passed * 15 / 100);                    
                }
                else
                {
                    overwrote = Math.Ceiling(passed * 5 / 100);                   
                }                
                students = passed + overwrote;                
            }
            Console.WriteLine($"Students: {students}");
        }
    }
}
