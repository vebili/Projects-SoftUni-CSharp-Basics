using System;

namespace _08.Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heaght = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int volume = length * width * heaght;
            double volumeLiters = volume * 0.001;
            double percentInNumber = percent / 100;
            double needLiters = volumeLiters * (1 - percentInNumber);
            Console.WriteLine($"{needLiters:F3}");
        }
    }
}
