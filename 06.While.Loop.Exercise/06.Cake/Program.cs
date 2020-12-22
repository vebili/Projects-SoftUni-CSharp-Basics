using System;
using System.Data;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //int cake = width * height;
            //string command = Console.ReadLine();
            ////int pieces = int.Parse(Console.ReadLine());
            //int sum = 0;
            //        //int pieces = int.Parse(Console.ReadLine());

            //while (command != "Stop")
            //{
            //        int pieces = int.Parse(command);
            //        sum += pieces;
            //    if (cake <= sum)
            //    {                    
            //        Console.WriteLine($"No more cake left! You need {sum - cake} pieces more.");
            //        return;
            //    }
            //    command = Console.ReadLine();
            //}
            //if (command == "STOP")
            //{
            //Console.WriteLine($"{cake - sum} pieces are left.");
            //}
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int piece = 0;
            string command = Console.ReadLine();
            int cake = width * height;
            while (command != "STOP")
            {
                piece = int.Parse(command) + piece;

                if (cake <= piece)
                {
                    Console.WriteLine($"No more cake left! You need {piece - cake} pieces more.");
                    return;
                }
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                Console.WriteLine($"{cake - piece} pieces are left.");
            }
        }
    }
}
