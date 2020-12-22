using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSal = double.Parse(Console.ReadLine());

            double scholarship = Math.Floor(minSal * 0.35);
            double scholarshipEx = Math.Floor(grade * 25);
            double printExScholarship = 0;

            if (scholarship > scholarshipEx)
            {
                printExScholarship = scholarship;
            }
            else
            {
                printExScholarship = scholarshipEx;
            }

            if (salary <= minSal && grade > 4.5 && grade < 5.5)
            {
                Console.WriteLine($"You get a Social scholarship {scholarship} BGN");
            }
            else if (salary <= minSal && grade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {printExScholarship} BGN");
            }
            else if (salary > minSal && grade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipEx} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
