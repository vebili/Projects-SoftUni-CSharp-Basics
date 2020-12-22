using System;

namespace _07VendingMachine
{
    class Program
{
    static void Main()
    {
        decimal customerMoney = 0m;
        string output = string.Empty;
        string notEnoughMoney = "Sorry, not enough money";

        string commandStart = Console.ReadLine();
        while (true)
        {
            decimal money = decimal.Parse(commandStart);
            bool acceptedCoins = (money == 0.1m || money == 0.2m || money == 0.5m
                                    || money == 1.00m || money == 2.00m);

            if (acceptedCoins)
            {
                customerMoney += money;
            }

            else
            {
                Console.WriteLine($"Cannot accept {money}");
            }
            commandStart = Console.ReadLine();
            if (commandStart == "Start")
            {
                break;
            }
        }

        string commandEnd = Console.ReadLine();
        while (commandEnd != "End")
        {
            string product = commandEnd;
            //bool invalidProduct = (product != "Nuts" || product != "Water" ||
            //product != "Crisps" || product != "Soda" || product != "Coke");
            bool nuts = product == "Nuts";
            bool water = product == "Water";
            bool crisps = product == "Crisps";
            bool soda = product == "Soda";
            bool coke = product == "Coke";

            if (nuts)
            {
                if (customerMoney < 2.00m)
                {
                    Console.WriteLine(notEnoughMoney);
                    commandEnd = Console.ReadLine();
                    continue;
                }

                else
                {
                    Console.WriteLine("Purchased nuts");
                    customerMoney -= 2.00m;
                }

            }

            else if (water)
            {
                if (customerMoney < 0.70m)
                {
                    Console.WriteLine(notEnoughMoney);
                    commandEnd = Console.ReadLine();
                    continue;
                }

                else
                {
                    Console.WriteLine("Purchased water");
                    customerMoney -= 0.70m;
                }
            }

            else if (crisps)
            {
                if (customerMoney < 1.50m)
                {
                    Console.WriteLine(notEnoughMoney);
                    commandEnd = Console.ReadLine();
                    continue;
                }

                else
                {
                    Console.WriteLine("Purchased crisps");
                    customerMoney -= 1.50m;
                }
            }

            else if (soda)
            {
                if (customerMoney < 0.80m)
                {
                    Console.WriteLine(notEnoughMoney);
                    commandEnd = Console.ReadLine();
                    continue;
                }

                else
                {
                    Console.WriteLine("Purchased soda");
                    customerMoney -= 0.80m;
                }
            }

            else if (coke)
            {
                if (customerMoney < 1.00m)
                {
                    Console.WriteLine(notEnoughMoney);
                    commandEnd = Console.ReadLine();
                    continue;
                }

                else
                {
                    Console.WriteLine("Purchased coke");
                    customerMoney -= 1.00m;
                }
            }

            else
            {
                Console.WriteLine("Invalid product");
                commandEnd = Console.ReadLine();
                continue;
            }



            commandEnd = Console.ReadLine();
        }

        Console.WriteLine($"Change: {customerMoney:f2}");
    }
}
}
