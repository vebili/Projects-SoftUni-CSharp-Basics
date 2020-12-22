using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double ownMoney = double.Parse(Console.ReadLine());
            int countSpendDays = 0;
            int countTotalDays = 0;

            while (ownMoney < needMoney)
            {
                string action = Console.ReadLine(); //spend or save
                double price = double.Parse(Console.ReadLine());
                countTotalDays++;
                if (action == "save")
                {
                    ownMoney += price;
                    countSpendDays = 0;
                }
                else if (action == "spend")
                {
                    countSpendDays++;
                    ownMoney -= price;
                    if (ownMoney < 0)
                    {
                        ownMoney = 0;
                    }
                }
                if (countSpendDays==5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countTotalDays);
                    break;
                }
            }
            if (ownMoney>=needMoney)
            {
                Console.WriteLine($"You saved the money for {countTotalDays} days.");
            }
        }
    }
}
