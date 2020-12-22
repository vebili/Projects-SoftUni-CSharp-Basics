using System;

namespace _01.Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double personalExpenses = double.Parse(Console.ReadLine());
            double savedMoney = (income - 30.0 / 100 * income - personalExpenses) * months;

            double maxPercentSaved = (savedMoney / (income * months))*100;
            Console.WriteLine($"She can save {maxPercentSaved:f2}%");
            Console.WriteLine($"{savedMoney:f2}");
        }
    }
}
