using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
                int num = int.Parse(Console.ReadLine());
                int minNumber = int.MaxValue;
                for (int i = 0; i < num; i++)
                {
                    int currentNumber = int.Parse(Console.ReadLine());
                    if (minNumber > currentNumber)
                    {
                        minNumber = currentNumber;
                    }
                }
            Console.WriteLine(minNumber);
        }
    }
}
