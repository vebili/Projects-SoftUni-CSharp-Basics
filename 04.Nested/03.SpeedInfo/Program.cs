using System;

namespace _03.SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Прочетете входните данни (скоростта): 
            //2.Използвайте if-else -if конструкция, за да проверите стойностите за скоростта
            //2.1 do 10 pr slow
            //2.2 do 50 pr average
            //2.3 do 150 pr fast
            //2.4 do 1000 pr ultra fast
            //2.5 nad 1000 pr extremely fast

            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
