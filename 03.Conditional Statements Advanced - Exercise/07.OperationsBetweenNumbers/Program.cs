using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            //„+“, „-“, „*“, „/“, „%“
            char operation = char.Parse(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    int sum = N1 + N2;
                    // even -> "{N1} {оператор} {N2} = {резултат} – {even}"
                    // odd -> "{N1} {оператор} {N2} = {резултат} – {odd}"
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{N1} + {N2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} + {N2} = {sum} - odd");
                    }
                    break;
                case '-':
                    int diff = N1 - N2;
                    if(diff % 2 == 0)
                    {
                        Console.WriteLine($"{N1} - {N2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} - {N2} = {diff} - odd");
                    }
                    break;
                case '*':
                    int result = N1 * N2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} * {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} * {N2} = {result} - odd");
                    }
                    break;
                case '/'://proverka dali N2 =0
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        double division = N1 * 1.00 / N2;
                        Console.WriteLine($"{N1} / {N2} = {division:f2}");
                    }                    
                    break;
                case '%':
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        int leftOver = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {leftOver}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
