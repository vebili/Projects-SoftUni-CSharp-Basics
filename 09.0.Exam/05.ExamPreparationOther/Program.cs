using System;

namespace _05.ExamPreparationOther
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsNum = double.Parse(Console.ReadLine());
            int problemsNum = int.Parse(Console.ReadLine());
            double energy = int.Parse(Console.ReadLine());
            int counterProblems = 0;
            double counterQestions = 0;


            while (studentsNum > 10)
            {
                for (int i = 1; i <= problemsNum; i++)
                {
                    counterProblems++;
                    energy += 2;
                    studentsNum--;
                }
                energy = energy - (studentsNum * 2 * 3);
                counterQestions += (studentsNum * 2);

                if (studentsNum < 10)
                {
                    Console.WriteLine("The students are too few!");
                    Console.WriteLine($"Problems solved: {counterProblems}");
                    return;
                }
                if (energy <= 0)
                {
                    Console.WriteLine("The trainer is too tired!");
                    Console.WriteLine($"Questions asked: {counterQestions}");
                    return;
                }
                studentsNum += Math.Floor(studentsNum / 10);
            }
        }
    }
}
