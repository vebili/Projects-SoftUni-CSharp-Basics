using System;

namespace _10.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. вход
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int heaight = int.Parse(Console.ReadLine());
            //1.1 изчисляване на своб. простр.
            int freeSpace = width * lenght * heaight;
            //2. структура за while loop за брой кашони
            string input = Console.ReadLine();
            while (input != "Done")
            {
                //2.1 махане на свободното пространство от наличното
                freeSpace -= int.Parse(input);
                //2.2  проверка дали своб. пространство не е по малко от 0
                if (freeSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {

                //4. Печат
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
