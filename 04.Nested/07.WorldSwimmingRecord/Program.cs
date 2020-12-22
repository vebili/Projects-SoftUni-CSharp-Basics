using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Иван решава да подобри Световния рекорд по плуване на дълги разстояния.На конзолата се въвежда рекордът в секунди, който Иван трябва да подобри,  разстоянието в метри, което трябва да преплува и времето в секунди, за което плува разстояние от 1 м.Да се напише програма, която изчислява дали се е справил със задачата, като се има предвид, че: съпротивлението на водата го забавя на всеки 15 м.с 12.5 секунди.Когато се изчислява колко пъти Иванчо ще се забави, в резултат на съпротивлението на водата, резултатът трябва да се закръгли надолу до най - близкото цяло число.
            //Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд. 
            //Вход
            //От конзолата се четат 3 реда:
            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]
            //Изход
            //Отпечатването на конзолата зависи от резултата:
            //•	Ако Иван е подобрил Световния рекорд отпечатваме:
            //o   " Yes, he succeeded! The new world record is {времето на Иван} seconds."
            //•	Ако НЕ е подобрил рекорда отпечатваме:
            //o"No, he failed! He was {недостигащите секунди} seconds slower."
            //Резултатът трябва да се форматира до втория знак след десетичната запетая.
            //1.kolko vreme pluva
            //2.kolko se zabavq
            //3.obshto vreme pluvane + zabavqne

            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double swimTime = distance * timePerMeter;
            double delayTime = Math.Floor(distance / 15) * 12.5;

            double totalTime = swimTime + delayTime;
            //podobrqva kgato vremeto e < ot rekorda
            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            //ne podobrava ako vremeto >= rekorda
            else
            {
                double needSeconds = totalTime - record;
                Console.WriteLine($"No, he failed! He was {needSeconds:F2} seconds slower.");
            }
        }
    }
}
