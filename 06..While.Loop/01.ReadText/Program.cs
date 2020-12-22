using System;

namespace _01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;

            while (input != "Stop")
            {                
                input = Console.ReadLine();
                counter++;
            }
            if (input == "Stop")
            {
            Console.WriteLine(counter);
            }
        }
    }
}
