using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която преобразува разстояние между следните 3 мерни единици: mm, cm, m.
            //Използвайте съответствията от таблицата по - долу:
            //входна единица  изходна единица
            //1 meter(m) 1000 millimeters(mm)
            //1 meter(m) 100 centimeters(cm)
            //Входните данни се състоят от три реда, въведени от потребителя:
            //•	Първи ред: число за преобразуване - реално число
            //•	Втори ред: входна мерна единица - текст
            //•	Трети ред: изходна мерна единица(за резултата) - текст
            //На конзолата да се отпечата резултатът от преобразуването на мерните единици форматиран до третия знак след десетичната запетая.
            double number = double.Parse(Console.ReadLine());
            string metric = (Console.ReadLine());
            string convert = (Console.ReadLine());

            if (metric == "mm")
            {
                if (convert == "m")
                {
                    Console.WriteLine($"{number * 0.001:F3}");
                }             
                else if(convert == "cm")
                {
                    Console.WriteLine($"{number * 0.1:F3}");
                }
            }
            else if(metric == "m")
            {
                if (convert == "cm")
                {
                    Console.WriteLine($"{number * 100:F3}");
                }
                else if (convert == "mm")
                {
                    Console.WriteLine($"{number * 1000:F3}");
                }
            }
            else if (metric == "cm")
            {
                if (convert == "m")
                {
                    Console.WriteLine($"{number * 0.01:F3}");
                }
                else if (convert == "mm")
                {
                    Console.WriteLine($"{number * 10:F3}");
                }
            }
        }
    }
}
