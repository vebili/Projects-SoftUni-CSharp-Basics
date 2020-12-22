using System;

namespace _03.ExamCategoriesOther
{
    class Program
    {
        static void Main(string[] args)
        {
            int complexity = int.Parse(Console.ReadLine());
            int rotation = int.Parse(Console.ReadLine());
            int numPage = int.Parse(Console.ReadLine());

            if (complexity >= 80 && rotation >= 80 && numPage >= 8)
            {
                Console.WriteLine("Legacy");
            }
            else if (complexity >= 80 && rotation <= 10)
            {
                Console.WriteLine("Master");
            }
            else if (rotation >= 50 && numPage >= 2)
            {
                Console.WriteLine("Hard");
            }
            else if (complexity <= 10)
            {
                Console.WriteLine("Elementary");
            }
            else if (complexity <= 30 && numPage <= 1)
            {
                Console.WriteLine("Easy");
            }
            else
            {
                Console.WriteLine("Regular");
            }
        }
    }
}
