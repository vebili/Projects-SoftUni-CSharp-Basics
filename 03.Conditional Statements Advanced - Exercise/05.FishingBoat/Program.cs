using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            double rentPrice = 0.0;
            switch (season)
            {//"Spring", "Summer", "Autumn", "Winter"
                case "Spring":
                    rentPrice = 3000;
                    if (num <= 6)
                    {
                        rentPrice -= rentPrice * 0.1;
                    }
                    else if (num >= 7 && num <= 11)
                    {
                        rentPrice -= rentPrice * 0.15;
                    }
                    else if (num > 12)
                    {
                        rentPrice -= rentPrice * 0.25;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    rentPrice = 4200;
                    if (num <= 6)
                    {
                        rentPrice -= rentPrice * 0.1;
                    }
                    else if (num >= 7 && num <= 11)
                    {
                        rentPrice -= rentPrice * 0.15;
                    }
                    else if (num > 12)
                    {
                        rentPrice -= rentPrice * 0.25;
                    }
                    break;
                case "Winter":
                    rentPrice = 2600;
                    if (num <= 6)
                    {
                        rentPrice -= rentPrice * 0.1;
                    }
                    else if (num >= 7 && num <= 11)
                    {
                        rentPrice -= rentPrice * 0.15;
                    }
                    else if (num > 12)
                    {
                        rentPrice -= rentPrice * 0.25;
                    }
                    break;
                default:
                    break;
            }
            //Цената зависи от сезона: Цената за наем на кораба през пролетта е  3000 лв.,през лятото и есента е  4200 лв.
            //•	Цената за наем на кораба през зимата е  2600 лв.
            //В зависимост от броя си групата ползва отстъпка:Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            //•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //•	Ако групата е от 12 нагоре  –  отстъпка от 25 %.
            //Рибарите ползват допълнително 5 % отстъпка, ако са четен брой 
            //освен ако не е есен - тогава нямат допълнителна отстъпка, 
            //която се начислява след като се приспадне отстъпката по горните критерии.
            // Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. 
            if ((season == "Spring" || season == "Summer" || season == "Winter") && (num % 2 == 0))
            {
                rentPrice -= rentPrice * 0.05;
            }
            double diff = Math.Abs(budget - rentPrice);
            if (budget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
            }
        }
    }
}
