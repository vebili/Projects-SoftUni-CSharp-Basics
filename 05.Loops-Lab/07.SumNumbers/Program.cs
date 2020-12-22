using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. read a number n
            
            int n = int.Parse(Console.ReadLine());
            //2. read n numbers
            //int currentNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
            }
            //3. sum the number
            //4. output sum
            Console.WriteLine(sum);
        }
    }
}
