using System;
using System.Security.Cryptography;

namespace _04.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0.0;
            //Съществуват следните отстъпки:
            //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            switch (flowers)
            {//"Roses":, "Dahlias":, "Tulips":, "Narcissus":, "Gladiolus":
                case "Roses":
                    if (number > 80)
                    {
                        sum = number * 5.00;
                        sum -= sum * 0.1;
                    }
                    else
                    {
                        sum = number * 5.00;
                    }
                    break;
                case "Dahlias":
                    if (number > 90)
                    {
                        sum = number * 3.80;
                        sum -= sum * 0.15;
                    }
                    else
                    {
                        sum = number * 3.80;
                    }
                    break;
                case "Tulips":
                    if (number > 80)
                    {
                        sum = number * 2.80;
                        sum -= sum * 0.15;
                    }
                    else
                    {
                        sum = number * 2.80;
                    }
                    break;
                case "Narcissus":
                    if (number < 120)
                    {
                        sum = number * 3.00;
                        sum += sum * 0.15;
                    }
                    else
                    {
                        sum = number * 3.00;
                    }
                    break;
                case "Gladiolus":
                    if (number < 80)
                    {
                        sum = number * 2.50;
                        sum += sum * 0.2;
                    }
                    else
                    {
                        sum = number * 2.50;
                    }
                    break;
            }
            double diff = Math.Abs(sum - budget);
            //Да се отпечата на конзолата на един ред:
            //•	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            //•	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."
            //Сумата да бъде форматирана до втория знак след десетичната запетая.
            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flowers} and {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {diff:F2} leva more.");
            }
        }
    }
}
