using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int input = 1; input <= n; input++)
            {
                if (input % 2 == 0)
                {
                    int num = int.Parse(Console.ReadLine());
                    even += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    odd += num;
                }
            }
            if (even == odd)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(even - odd)}");
            }
        }
    }
}
