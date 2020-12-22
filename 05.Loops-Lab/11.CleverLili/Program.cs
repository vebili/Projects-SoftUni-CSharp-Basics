using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            //            11.Умната Лили
            //Лили вече е на N години.За всеки свой рожден ден тя получава подарък. За нечетните рождени дни(1, 3, 5...n) получава играчки, а за всеки четен(2, 4, 6...n) получава пари. За втория рожден ден получава 10.00 лв, като сумата се увеличава с 10.00 лв., за всеки следващ четен рожден ден(2-> 10, 4-> 20, 6-> 30...и т.н.). През годините Лили тайно е спестявала парите.Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев от тях.Лили продала играчките получени през годините, всяка за P лева и добавила сумата към спестените пари.С парите искала да си купи пералня за X лева. Напишете програма, която да пресмята, колко пари е събрала и дали ѝ стигат да си купи пералня.
            //Вход
            //Програмата прочита 3 числа, въведени от потребителя, на отделни редове:
            //•	Възрастта на Лили - цяло число в интервала[1...77]
            //•	Цена на пералнята – реално число
            //•	Цена на играчките – реално число
            //•	Цената на пералнята - 1
            //Изход
            //Да се отпечата на конзолата един ред:
            //•	Ако парите на Лили са достатъчни:
            //o   “Yes! { N}” -където N е остатъка пари след покупката
            //•	Ако парите не са достатъчни:
            //            o   “No! { М}“ -където M е сумата, която не достига
            //•	Числата N и M трябва да за форматирани до вторият знак след десетичната запетая.

            //1. read input
            int age = int.Parse(Console.ReadLine());
            double washingMashine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            //2. loop through the bdays
            //4. create a sum var for the money and var for the money gift
            double moneyFromBdays = 0;
            double moneyGift = 10;
            int numOfToys = 0;
            for (int birthday = 1; birthday <= age; birthday++)
            {
                //3. check if the birthday is even or odd
                if (birthday % 2 == 0)
                {
                    moneyFromBdays += moneyGift;
                    moneyGift += 10;
                    moneyFromBdays--; // for her brother
                }
                else
                {
                    numOfToys++;
                }
            }
            double totalMoneyFromToys = numOfToys * toyPrice;
            double totalMoney = totalMoneyFromToys + moneyFromBdays;
            if (totalMoney >= washingMashine)
            {
                Console.WriteLine($"Yes! {totalMoney - washingMashine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMashine - totalMoney:f2}");
            }
        }
    }
}
