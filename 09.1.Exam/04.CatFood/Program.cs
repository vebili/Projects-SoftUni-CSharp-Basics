using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CatFood
{
    class Program
    {
        static void Main(string[] args)
            {
                int numbOfCats = int.Parse(Console.ReadLine());

                int catCounter = 1;
                int group1 = 0;
                int group2 = 0;
                int group3 = 0;
                double totalFoodWeightGrams = 0;
                while (catCounter <= numbOfCats)
                {
                    double foodWeightInGrams = double.Parse(Console.ReadLine());
                    totalFoodWeightGrams += foodWeightInGrams;
                    if (foodWeightInGrams >= 100 && foodWeightInGrams < 200)
                    {
                        group1++;
                    }
                    else if (foodWeightInGrams >= 200 && foodWeightInGrams < 300)
                    {
                        group2++;
                    }
                    else if (foodWeightInGrams >= 300 && foodWeightInGrams <= 400)
                    {
                        group3++;
                    }

                    catCounter++;
                }

                double priceForFood = (totalFoodWeightGrams / 1000) * 12.45;
            priceForFood = Math.Floor(priceForFood * 100) / 100;
            Console.WriteLine($"Group 1: {group1} cats.");
                Console.WriteLine($"Group 2: {group2} cats.");
                Console.WriteLine($"Group 3: {group3} cats.");
                Console.WriteLine($"Price for food per day: {priceForFood:F2} lv.");
        }
    }
}