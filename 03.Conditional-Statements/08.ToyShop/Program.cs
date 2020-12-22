using System;

namespace _08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]
            //Цени на играчките:
            //•	Пъзел - 2.60 лв.
            //•	Говореща кукла -3 лв.
            //•	Плюшено мече -4.10 лв.
            //•	Миньон - 8.20 лв.
            //•	Камионче - 2 лв.
            //•	Ако парите са достатъчни се отпечатва:
            //o   "Yes! {оставащите пари} lv left."
            //•	Ако парите НЕ са достатъчни се отпечатва:
            //  o   "Not enough money! {недостигащите пари} lv needed."
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //1. calculate the profit from the toys
            double totalProfit = puzzels * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

            //2. check if the number is >= 50
            //if yes -> -25%
            int numberOfToys = puzzels + dolls + bears + minions + trucks;
            if(numberOfToys>= 50)
            {
                totalProfit = totalProfit - 0.25 * totalProfit;
                //totalProfit = totalProfit * 0.75;
                //totalProfit -= totalProfit * 0.25;
            }

            //3. -10% from the profit -> rent 
            totalProfit = totalProfit * 0.90;

            //4. check if the money is enough for holiday
            double diff = Math.Abs(totalProfit - holidayPrice);
            if (totalProfit >= holidayPrice)
            {
                Console.WriteLine($"Yes! {(diff)/*(totalProfit- holidayPrice)*/:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(diff)/*(holidayPrice - totalProfit)*/:f2} lv needed.");
            }
        }
    }
}
