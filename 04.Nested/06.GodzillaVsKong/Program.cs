using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Снимките за дългоочаквания филм "Годзила срещу Конг" започват.Сценаристът Адам Уингард ви моли да напишете програма, която да изчисли, дали предвидените средства са достатъчни за снимането на филма. За снимките  ще бъдат нужни определен брой статисти, облекло за всеки един статист и декор.
            //Известно е, че:
            //1.1•	Декорът за филма е на стойност 10 % от бюджета.
            //1.2•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.
            //Вход
            //От конзолата се четат 3 реда:
            //Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]
            //Изход
            //На конзолата трябва да се отпечатат два реда:
            //•	Ако парите за декора и дрехите са повече от бюджета:
            //o   "Not enough money!"
            //o   "Wingard needs {парите недостигащи за филма} leva more."
            //•	Ако парите за декора и дрехите са по малко или равни на бюджета:
            //o   "Action!"
            //o   "Wingard starts filming with {останалите пари} leva left."
            //Резултатът трябва да е форматиран до втория знак след десетичната запетая.
            double budget = double.Parse(Console.ReadLine());
            int countStatist = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());
            
            double decor = 0.10 * budget;
            double clothes = countStatist * pricePerStatist;
            if (countStatist > 150)
            {
                clothes = clothes - 0.10 * clothes;
            }

            double expences = decor + clothes;
            if (budget >= expences)
            {
                Console.WriteLine("Action!");
                double leftMoney = budget - expences;
                Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                double needMoney = expences - budget;
                Console.WriteLine($"Wingard needs {needMoney:F2} leva more.");

            }
        }
    }
}
