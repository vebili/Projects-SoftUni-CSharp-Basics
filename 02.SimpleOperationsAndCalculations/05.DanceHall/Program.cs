using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double areaHall = (length * 100) * (width * 100);
            double areaBench = areaHall / 10;
            double areaWardrobe = (wardrobeSide * 100) * (wardrobeSide * 100);
            double freeSpace = areaHall - areaBench - areaWardrobe;

            double countPeople = freeSpace / 7040;
            Console.WriteLine(Math.Floor(countPeople));
        }
    }
}
