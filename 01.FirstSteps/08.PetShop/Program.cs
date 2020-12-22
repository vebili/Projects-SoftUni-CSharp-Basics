using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int restOfAnimals = int.Parse(Console.ReadLine());
            double sumDogs = dogs * 2.50;
            double sumRest = restOfAnimals * 4.00;
            double sum = sumDogs + sumRest;
            Console.WriteLine($"{sum} lv.");
        }
    }
}