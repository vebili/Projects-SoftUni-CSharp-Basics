using System;

namespace _091.Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double comis = double.Parse(Console.ReadLine());

            double bitcoin1 = 1168;
            double yuan1 = 0.15;
            double dollar = 1.76;
            double euro = 1.95;
            double comPercent = comis / 100;

            double allBitcoinLeva = bitcoin * bitcoin1;
            double yuanDollar = yuan * yuan1;
            double dollarLeva = yuanDollar * dollar;
            double allLeva = dollarLeva + allBitcoinLeva;
            double allEuro = allLeva / euro;

            double sum = Math.Abs(allEuro * comPercent - allEuro);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
