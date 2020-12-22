using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. create a variable
            string input = Console.ReadLine();
            double sum = 0;
            //2. bool inside loop
            while (input != "Stop")
            {
                sum += double.Parse(input);
                //3. change the value of the main variable
                input = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
