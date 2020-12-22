using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            for (int i = 0; i < num; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
