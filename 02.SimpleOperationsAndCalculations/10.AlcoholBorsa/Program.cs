using System;

namespace _10.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // obshta suma = 
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double brandyQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double brandyPrice = whiskeyPrice / 2;
            double sumBrandy = brandyQuantity * brandyPrice;

            double beerPrice = brandyPrice - 0.8 * brandyPrice;//0.2*brandyPrice
            double sumBeer = beerQuantity * beerPrice;

            double winePrice = brandyPrice - 0.4 * brandyPrice;//0.6*brandyPrice
            double sumWine = wineQuantity * winePrice;

            double sumWhiskey = whiskeyQuantity * whiskeyPrice;

            double totalSum = sumBeer + sumWine + sumBrandy + sumWhiskey;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
