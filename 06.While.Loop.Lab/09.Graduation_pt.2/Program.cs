using System;

namespace _09.Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 1;
            double sum = 0;

            while (grade <= 12)
            {
                double input = double.Parse(Console.ReadLine());
                if (input >= 4)
                {
                    sum += input;
                    grade++;
                }
                if (input < 4)
                {
                    sum += input;
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    return;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
        }
    }
}
