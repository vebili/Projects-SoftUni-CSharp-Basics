using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());//br masi
            double lengthTables = double.Parse(Console.ReadLine());// dulj masa
            double widthTables = double.Parse(Console.ReadLine());// shir masa

            double tablem2 = tables * (lengthTables + 2 * 0.3) * (widthTables + 2 * 0.3);
            double karem2 = tables * (lengthTables/2) * (lengthTables/2);

            double allPriceUSD = tablem2 * 7 + karem2 * 9;
            
            double allPriceBGN = (tablem2 * 7 * 1.85) + (karem2 * 9 * 1.85);
           
            Console.WriteLine($"{allPriceUSD:F2} USD");
            Console.WriteLine($"{allPriceBGN:F2} BGN");
        }
    }
}
