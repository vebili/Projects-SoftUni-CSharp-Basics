using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            //May, June, July, August, September или October
            int nights = int.Parse(Console.ReadLine());
            //1. prices
            double priceStudio = 0;
            double priceApartment = 0;

            //proverka may oct
            if (month == "May" || month == "October")
            {
                priceStudio = nights * 50;
                priceApartment = nights * 65;
                if (nights > 7 && nights <= 14)
                {
                    priceStudio = priceStudio - 0.05 * priceStudio;
                    //0.95 * priceStudio;
                }
                else if (nights > 14)
                {
                    priceStudio = priceStudio - 0.30 * priceStudio;
                    //0.70 * priceStudio;
                }
                else if (nights > 14)
                {
                    priceStudio = priceStudio - 0.30 * priceStudio;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = nights * 75.20;
                priceApartment = nights * 68.70;
                if (nights > 14)
                {
                    priceStudio = priceStudio - 0.20 * priceStudio;
                    //0.8 * priceStudio
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = nights * 76;
                priceApartment = nights * 77;
            }
            //2. discounts
            if (nights > 14)
            {
                priceApartment = priceApartment - priceApartment * 0.1;
                //0.9 * priceApartment
            }
            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
