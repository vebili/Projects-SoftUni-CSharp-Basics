using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();//ili chislo ili text ... do stop

            //suma prosti -> delqt se na sebe si i na 1
            //suma sastavni -> kogato imat poveche ot 2 delitelq
            int sumPrime = 0;
            int sumNoPrime = 0;

            while (command != "stop")
            {
                //chislo pod formata na text
                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    //operacii
                    //proverka dali e prosta
                    int count = 0; //broi na delitelite
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }
                    }//znaem broqt na delitelite
                    if (count == 2)
                    {
                        sumPrime += number;
                    }
                    else if (count > 2)
                    {
                        sumNoPrime += number;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNoPrime}");
        }
    }
}
