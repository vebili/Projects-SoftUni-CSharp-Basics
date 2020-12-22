using System;

namespace _01.NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //
            //for (int number = 1; number  <= 1000; number ++)
            //{
            //    if(number % 10 == 7)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            for (int number = 7; number <= 997; number+=10)
            {                
                    Console.WriteLine(number);                
            }
        }
    }
}
