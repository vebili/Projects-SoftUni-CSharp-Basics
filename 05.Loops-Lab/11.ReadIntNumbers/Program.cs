using System;

namespace _12.ReadIntNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. read a number n

            int n = int.Parse(Console.ReadLine());
            int maxNum = 0;// int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
            }


            //10 maxNum =10
            //20 maxNum =20
            //304 maxNum =304
            //0 
            //50
            int maxNum = 0;

            int minNum = 1000000000;// int.MaxValue
        }
    }
}
