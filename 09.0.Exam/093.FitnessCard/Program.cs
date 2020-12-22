using System;

namespace _03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double haveMoney = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double cardPrice = 0;

            if (sex == 'm')
            {
                if (sport == "Gym")
                {
                    cardPrice = 42;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Boxing")
                {
                    cardPrice = 41;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Yoga")
                {
                    cardPrice = 45;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Zumba")
                {
                    cardPrice = 34;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Dances")
                {
                    cardPrice = 51;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Pilates")
                {
                    cardPrice = 39;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
            }
            else if (sex == 'f')
            {
                if (sport == "Gym")
                {
                    cardPrice = 35;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Boxing")
                {
                    cardPrice = 37;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Yoga")
                {
                    cardPrice = 42;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Zumba")
                {
                    cardPrice = 31;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Dances")
                {
                    cardPrice = 53;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
                else if (sport == "Pilates")
                {
                    cardPrice = 37;
                    if (age <= 19)
                    {
                        cardPrice = cardPrice * 0.80;
                    }
                }
            }
            if (haveMoney >= cardPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${Math.Abs(haveMoney-cardPrice):f2} more.");
            }
        }
    }
}
