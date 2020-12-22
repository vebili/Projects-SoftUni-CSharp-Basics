using System;

namespace _09.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            bool cond1 = (sales >= 0 && sales <= 500);// 0 ≤ s ≤ 500
            bool cond2 = (sales > 500 && sales <= 1000);
            bool cond3 = (sales > 1000 && sales <= 10000);
            bool cond4 = sales > 10000;
            double comiss = 0;
            if (town == "Sofia")
            {
                if (cond1)
                {
                    comiss = sales * 5 / 100;
                }
                else if (cond2)
                {
                    comiss = sales * 7 / 100;
                }
                else if (cond3)
                {
                    comiss = sales * 8 / 100;
                }
                else if (cond4)
                {
                    comiss = sales * 12 / 100;
                }
            }
            else if (town == "Plovdiv")
            {
                if (cond1)
                {
                    comiss = sales * 5.5 / 100;
                }
                else if (cond2)
                {
                    comiss = sales * 8 / 100;
                }
                else if (cond3)
                {
                    comiss = sales * 12 / 100;
                }
                else if (cond4)
                {
                    comiss = sales * 14.5 / 100;
                }
            }
            else if (town == "Varna")
            {
                if (cond1)
                {
                    comiss = sales * 4.5 / 100;
                }
                else if (cond2)
                {
                    comiss = sales * 7.5 / 100;
                }
                else if (cond3)
                {
                    comiss = sales * 10 / 100;
                }
                else if (cond4)
                {
                    comiss = sales * 13 / 100;
                }
            }

            if ((town == "Varna" || town == "Plovdiv" || town == "Sofia") && (cond1 || cond2 || cond3 || cond4))
            {
                Console.WriteLine($"{comiss:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
