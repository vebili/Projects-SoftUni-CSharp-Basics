using System;

namespace _05.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_Number = int.Parse(Console.ReadLine());
            int l_number = int.Parse(Console.ReadLine());

            for (int i = 1; i < n_Number; i++)
            {
                for (int j = 1; j < n_Number; j++)
                {
                    for (int k = 'a'; k < 'a' + l_number; k++)
                    {
                        for (int l = 'a'; l < 'a' + l_number; l++)
                        {
                            for (int m = 2; m <= n_Number; m++)
                            {

                                if (m > i && m > j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)l}{m} ");
                                }


                            }
                        }
                    }
                }
            }
        }
    }
}
