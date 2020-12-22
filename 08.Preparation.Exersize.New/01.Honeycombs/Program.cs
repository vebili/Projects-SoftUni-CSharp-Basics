using System;

namespace _01.Honeycombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBees = int.Parse(Console.ReadLine());
            int numFlowers = int.Parse(Console.ReadLine());
            double honey = numBees * numFlowers * 0.21;
            double honeyCombs = Math.Floor(honey / 100);
            double honeyLeft = honey - honeyCombs * 100;
            Console.WriteLine($"{honeyCombs} honeycombs filled.");
            Console.WriteLine($"{honeyLeft:f2} grams of honey left.");
        }
    }
}
