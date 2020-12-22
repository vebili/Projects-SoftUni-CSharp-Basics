using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = int.Parse(Console.ReadLine());
            if (counter <= 10)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {counter} = {num * counter}");
                    counter++;
                }
            }
            else
            {
                Console.WriteLine($"{num} X {counter} = {num * counter}");
            }
        }
    }
}
