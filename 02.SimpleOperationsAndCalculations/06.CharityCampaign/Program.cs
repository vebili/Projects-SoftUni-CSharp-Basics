using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofretti = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double priceCakes = cakes * 45;
            double priceGofretti = gofretti * 5.80;
            double pricePancakes = pancakes * 3.20;

            double allPrice = days * bakers * (priceCakes + priceGofretti + pricePancakes);
            double finalPrice = allPrice - (allPrice / 8);

            Console.WriteLine($"{finalPrice:F2}");

        }
    }
}
