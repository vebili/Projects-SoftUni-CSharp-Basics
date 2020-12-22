using System;

namespace TestPoolDay
{
    class TestPoolDay
    {
        static void Main(string[] args)
         {
            int people = int.Parse(Console.ReadLine());
            double entranceTax = double.Parse(Console.ReadLine());
            double loungePrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalEnterPrice = entranceTax * people;
            double loungeCnt = Math.Ceiling(people * 0.75);
            double umbrellaCnt = Math.Ceiling(people / 2.0);

            double finalPrice = totalEnterPrice + loungeCnt * loungePrice + umbrellaCnt * umbrellaPrice;

            Console.WriteLine($"{finalPrice:F2} lv.");
        }
    }
}