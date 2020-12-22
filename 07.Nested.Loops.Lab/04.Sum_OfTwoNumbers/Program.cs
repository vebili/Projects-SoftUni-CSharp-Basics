using System;

namespace _04.Sum_OfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;
            for (int i = startingNumber; i <= finalNumber; i++)
            {
                for (int j = startingNumber; j <= finalNumber; j++)
                {
                    combinations++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound == false)
            {

                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
