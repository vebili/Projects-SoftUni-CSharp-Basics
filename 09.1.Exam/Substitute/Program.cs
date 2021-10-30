using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = K; i <= 8; i++)
            {
                for (int q = 9; q >= N; q--)
                {
                    for (int p = L; p <= 8; p++)
                    {
                        for (int o = 9; o >= M; o--)
                        {
                            if (i % 2 == 0 && q % 2 != 0 && p % 2 == 0 && o % 2 != 0)
                            {
                                if (i == p && q == o)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{i}{q} - {p}{o}");
                                    counter++;
                                    if (counter == 6)
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}