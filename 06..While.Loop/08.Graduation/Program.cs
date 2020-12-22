using System;

namespace _08.Graduation
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
            }
            Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
        }
    }
}
