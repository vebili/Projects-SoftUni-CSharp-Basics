using System;

namespace _04.ExamRetentionOther
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalStudents = double.Parse(Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());

            double restudents = 0;

            for (int i = 1; i <= seasons; i++)
            {
                if (i % 3 != 0)
                {
                    totalStudents = Math.Ceiling(totalStudents * 0.9);
                    totalStudents = Math.Ceiling(totalStudents * 0.9);
                    totalStudents = Math.Ceiling(totalStudents * 0.80);
                    restudents = Math.Ceiling((totalStudents * 5) / 100);
                    totalStudents += restudents;
                }
                else if (i % 3 == 0)
                {
                    totalStudents = Math.Ceiling(totalStudents * 0.9);
                    totalStudents = Math.Ceiling(totalStudents * 0.9);
                    totalStudents = Math.Ceiling(totalStudents * 0.80);
                    restudents = Math.Ceiling((totalStudents * 15) / 100);
                    totalStudents += restudents;
                }
            }
            Console.WriteLine($"Students: {totalStudents}");
        }
    }
}
