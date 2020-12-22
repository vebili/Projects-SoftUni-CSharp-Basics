using System;

namespace _08.Test2
{
    class Program
    {
        static void Main(string[] args)
        {
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
