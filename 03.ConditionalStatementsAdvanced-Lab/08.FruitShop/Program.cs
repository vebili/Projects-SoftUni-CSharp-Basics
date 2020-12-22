using System;

namespace _08.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool cond1 = (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday");
            bool cond2 = (day == "Saturday" || day == "Sunday");
            bool cond3 = (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes");
            double price = 0;
            if (cond1 && cond3)
            {
                if (fruit == "banana")
                    price = 2.50;
                else if (fruit == "apple")
                    price = 1.20;
                else if (fruit == "orange")
                    price = 0.85;
                else if (fruit == "grapefruit")
                    price = 1.45;
                else if (fruit == "kiwi")
                    price = 2.70;
                else if (fruit == "pineapple")
                    price = 5.50;
                else if (fruit == "grapes")
                    price = 3.85;
                double total = price * quantity;
                Console.WriteLine($"{total:F2}");
            }
            else if (cond2 && cond3)
            {
                if (fruit == "banana")
                    price = 2.70;
                else if (fruit == "apple")
                    price = 1.25;
                else if (fruit == "orange")
                    price = 0.90;
                else if (fruit == "grapefruit")
                    price = 1.60;
                else if (fruit == "kiwi")
                    price = 3.00;
                else if (fruit == "pineapple")
                    price = 5.60;
                else if (fruit == "grapes")
                    price = 4.20;
                double total = price * quantity;
                Console.WriteLine($"{total:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
