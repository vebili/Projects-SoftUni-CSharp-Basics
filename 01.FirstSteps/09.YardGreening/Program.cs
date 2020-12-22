using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardSquareMeters = double.Parse(Console.ReadLine());
            double sumYard = yardSquareMeters * 7.61;
            double discount = sumYard * 0.18;
            double sumFinal = sumYard - discount;
            Console.WriteLine($"The final price is: {sumFinal:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}