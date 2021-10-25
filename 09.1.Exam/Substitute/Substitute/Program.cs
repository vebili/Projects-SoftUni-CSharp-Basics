using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int substitutes = 0;

            for (int i = K; i <= 8; i++)
            {
                for (int p = 9; p >= L; p--)
                {
                    for (int h = M; h <= 8; h++)
                    {
                        for (int f = 9; f >= N; f--)
                        {
                            if (i % 2 == 0 && h % 2 == 0 && p % 2 != 0 && f % 2 != 0)
                            {
                                if (substitutes >= 6)
                                {
                                    return;
                                }
                                string checker = i.ToString() + p.ToString();
                                string checker2 = h.ToString() + f.ToString();
                                if (checker == checker2)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{i}{p} - {h}{f}");
                                    substitutes++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}