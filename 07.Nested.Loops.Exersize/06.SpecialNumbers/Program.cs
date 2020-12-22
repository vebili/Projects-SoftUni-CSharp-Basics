using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1111; number <= 9999; number++)
            {
                //proverka dali e special
                //vzimame vsqka edna cifra
                int thousands = number / 1000;
                int hundreds = (number / 100) % 10;
                int tens = (number / 10) % 10;
                int units = number % 10;
                //proverka dali e special n % tens ==0
                bool check1 = thousands != 0 && n % thousands == 0;
                bool check2 = hundreds != 0 && n % hundreds == 0;
                bool check3 = tens != 0 && n % tens == 0;
                bool check4 = units != 0 && n % units == 0;
                if (check1 && check2 && check3 && check4)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
