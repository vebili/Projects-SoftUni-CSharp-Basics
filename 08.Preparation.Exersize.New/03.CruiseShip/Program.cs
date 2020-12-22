using System;

namespace _03.CruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruise = Console.ReadLine();
            string cabin = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = 0;


            switch (cabin)
            {
                case "standard cabin":
                    switch (cruise)
                    {
                        case "Mediterranean":
                            pricePerNight = 27.50;
                            break;
                        case "Adriatic":
                            pricePerNight = 22.99;
                            break;
                        case "Aegean":
                            pricePerNight = 23.00;
                            break;
                    }
                    break;
                case "cabin with balcony":
                    switch (cruise)
                    {
                        case "Mediterranean":
                            pricePerNight = 30.20;
                            break;
                        case "Adriatic":
                            pricePerNight = 25.00;
                            break;
                        case "Aegean":
                            pricePerNight = 26.60;
                            break;
                    }
                    break;
                case "apartment":
                    switch (cruise)
                    {
                        case "Mediterranean":
                            pricePerNight = 40.50;
                            break;
                        case "Adriatic":
                            pricePerNight = 34.99;
                            break;
                        case "Aegean":
                            pricePerNight = 39.80;
                            break;
                    }
                    break;
            }

            double totalPrice = pricePerNight * nights * 4;
            if (nights>7)
            {
                totalPrice -= totalPrice * 0.25;
            }
            Console.WriteLine($"Annie's holiday in the {cruise} sea costs {totalPrice:f2} lv.");

        }
    }
}
//                    Mediterranean Adriatic Aegean
//standard cabin       27.50 лв.   22.99 лв.   23.00 лв.
//cabin with balcony   30.20 лв.   25.00 лв.   26.60 лв.
//apartment            40.50 лв.   34.99 лв.   39.80 лв.
