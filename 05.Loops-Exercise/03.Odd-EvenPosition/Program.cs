using System;

namespace _03.Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //нечетни позиции - сума от числата на неч. позиц, мин и мах число
            //четни позиции - сума от числата на ч. позиц, мин и мах число
            int n = int.Parse(Console.ReadLine());
            double sumOdd = 0;
            double sumEven = 0;
            double maxOdd = -1000000000.0;
            double maxEven = -1000000000.0;
            double minOdd = 1000000000.0;
            double minEven = 1000000000.0;
            
            //през всички числа от 1 до n
            for (int numberPosition = 1; numberPosition <= n; numberPosition++)
            {
                double number = double.Parse(Console.ReadLine());
                //chetna
                if (numberPosition % 2 == 0)
                {
                    sumEven += number;
                    //проверка за макс
                    if (number > maxEven)
                    {
                        maxEven = number;
                    }
                    if (number < minEven) //проверка за мin
                    {
                        minEven = number;
                    }
                }
                else //нечетна позиция
                {
                    sumOdd += number;
                    //проверка за макс
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd) //проверка за мin
                    {
                        minOdd = number;
                    }
                }
            }
            //
            //Изход
            //"OddSum=" + {сума на числата на нечетни позиции},
            //"OddMin=" + { минимална стойност на числата на нечетни позиции } / {“No”},
            //"OddMax=" + { максимална стойност на числата на нечетни позиции } / {“No”},
            //"EvenSum=" + { сума на числата на четни позиции },
            //"EvenMin=" + { минимална стойност на числата на четни позиции } / {“No”},
            //"EvenMax=" + { максимална стойност на числата на четни позиции } / {“No”}


            Console.WriteLine($"OddSum={sumOdd:F2},");
            if (minOdd == 1000000000.0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:F2},");
            }
            if (maxOdd == -1000000000.0)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd:F2},");
            }


            Console.WriteLine($"EvenSum={sumEven:F2},");
            if (minEven == 1000000000.0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:F2},");
            }
            if (maxEven == -1000000000.0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven:F2}");
            }
        }
    }
}
