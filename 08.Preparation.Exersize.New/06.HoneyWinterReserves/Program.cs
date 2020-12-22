using System;
using System.Diagnostics.Tracing;

namespace _06.HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ще получите необходимия мед за зимата. До получаване на команда "Winter has come" ще получавате име на пчела.След това ще прочитате добива мед на съответната пчела за 6 месеца, всеки на отделен ред. Ако получите отрицателно число, то пчелата за този месец е изяла повече мед, отколкото е събрала. Поради това тя бива прокудена, принтирайте: "{име на пчела} was banished for gluttony"
            //Ако след 6 - те месеца добив на дадена пчела общият събран от пчелите мед е достатъчен за зимата, принтирайте: "Well done! Honey surplus {събраният в повече мед}." и преустановете програмата.
            //  Вход:
            //•	На първи ред получавате количесто мед за зимата: реално число[1.00 - 1000.00].
            //•	На следващите до получаване на "Winter has come"редове ще получавате:
            //Име на пчела: string
            //На следващите 6 реда ще получавате добития от пчелата мед: реално число[-1000.00 - 1000.00]. 
            //Ако накрая на 6 - те месеца пчелата е изяла повече мед, отколкото е събрала, принтирайте:
            //"{име на пчела} was banished for gluttony"
            //Изход:
            //•	Ако събраният мед е достатъчен за зимата, принтирайте:
            //"Well done! Honey surplus {събраният в повече мед}."
            //•	Ако медът не е достатъчен, принтирайте:
            //"Hard Winter! Honey needed {недостигащият мед}."
            //•	Изходът форматирайте до втория знак след десетичната запетая.
            double honey = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string input = Console.ReadLine();
            int counter = 0;
            double sum = 0;
            while (input != "Winter has come")
            {
                double totalHoney = double.Parse(input);
                sum += totalHoney;


                counter++;
                input = Console.ReadLine();
            }
            if (honey <= sum)
            {
                Console.WriteLine($"Well done! Honey surplus {sum - honey:f2}.");
            }
            else if (honey > sum)
            {
                Console.WriteLine($"{name} was banished for gluttony");
            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {Math.Abs(sum - honey):f2}.");
            }
        }
    }
}
