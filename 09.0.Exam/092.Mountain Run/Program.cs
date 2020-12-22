using System;

namespace _02.Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distan = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());
            double totalTime = distan * timeInSec;
            double delay = Math.Floor(distan / 50) * 30;
            double total = totalTime + delay;
            if (record > total)
            {
            Console.WriteLine($" Yes! The new record is {total:f2} seconds.");
            }
            else
            {
            Console.WriteLine($"No! He was {(total - record):f2} seconds slower.");
            }
        }
    }
}
