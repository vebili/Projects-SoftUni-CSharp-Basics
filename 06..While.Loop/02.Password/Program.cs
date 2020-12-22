using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string input = Console.ReadLine();
            int counter = 1;
            while (input != password)
            {
                if (counter == 5)
                {
                    Console.WriteLine("You typed 5 incorrect passwords!");
                    break;
                }
                input = Console.ReadLine();
                counter++;
                
            }
            Console.WriteLine("Number of tries:" + counter);
            if (input == password)
            {
                Console.WriteLine($"Welcome {username}!");
            }
            
        }
    }
}
