using System;

namespace _01.Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int mark = int.Parse(Console.ReadLine());
            double cleanBoard = double.Parse(Console.ReadLine());
            int commiss = int.Parse(Console.ReadLine());
            double sum = pen * 5.80 + mark * 7.20 + cleanBoard * 1.20;
            double sumDiss = sum - (sum * commiss / 100);
            
            Console.WriteLine($"{sumDiss:f3}");
        }
    }
}
