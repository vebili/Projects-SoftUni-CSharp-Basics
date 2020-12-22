using System;

namespace _10.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //вид помещение       по - малко от 10 дни       между 10 и 15 дни        повече от 15 дни
            //apartment          30 % от крайната цена    35 % от крайната цена    50 % от крайната цена
            //president apartment 10 % от крайната цена    15 % от крайната цена    20 % от крайната цена
            //1. read input
            //2. calculate the total price
            //3. calculate the discount and add it to the total price
            //4. check the feeback and add / substract money

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();

            double price = 0;
            double discount = 0;
            switch (room)
            {
                case "room for one person":
                    price = 18;
                    break;
                case "apartment":
                    price = 25;
                    if (days < 10)
                    {
                        discount = 0.30;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                    }
                    else if (days > 15)
                    {
                        discount = 0.50;
                    }
                    break;
                case "president apartment":
                    price = 35;
                    if (days < 10)
                    {
                        discount = 0.10;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                    }
                    else if (days > 15)
                    {
                        discount = 0.20;
                    }
                    break;
            }

            double totalPrice = price * (days - 1);

            totalPrice -= totalPrice * discount;

            if(feedback == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else
            {
                totalPrice -= totalPrice * 0.10;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
