using System;

namespace _05.Coins1
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            double lv = Math.Floor(coins);
            double moneti = Math.Round((coins - lv) * 100);
            double br = 0;

            while (lv > 0)
            {
                if (lv >= 2)
                {
                    br += 1;
                    lv -= 2;
                }
                else if (lv >= 1)
                {
                    br += 1;
                    lv -= 1;
                }
            }
            while (moneti > 0)
            {
                if (moneti >= 50)
                {
                    br += 1;
                    moneti -= 50;
                }
                else if (moneti >= 20)
                {
                    br += 1;
                    moneti -= 20;
                }
                else if (moneti >= 10)
                {
                    br += 1;
                    moneti -= 10;
                }
                else if (moneti >= 05)
                {
                    br += 1;
                    moneti -= 05;
                }
                else if (moneti >= 02)
                {
                    br += 1;
                    moneti -= 02;
                }
                else if (moneti >= 01)
                {
                    br += 1;
                    moneti -= 01;
                    break;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(br);
        }
    }
}
