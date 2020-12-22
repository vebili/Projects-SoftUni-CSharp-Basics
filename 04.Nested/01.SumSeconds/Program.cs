using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. vxodnite danni
            //2. obshto vreme 1+2+3 =obshto vreme v sec
            //3. vreme ot sec v min
            //4. print + check

            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTimeInSeconds = firstTime + secondTime + thirdTime;
            int timeInMinutes = totalTimeInSeconds / 60;
            int timeInSeconds = totalTimeInSeconds % 60;

            if (timeInSeconds < 10)
            {
                Console.WriteLine(timeInMinutes + ":0" + timeInSeconds);
            }
            else
            {
                Console.WriteLine(timeInMinutes + ":" + timeInSeconds);
                Console.WriteLine($"{timeInMinutes} + : + {timeInSeconds:D2}");
            }
        }
    }
}
