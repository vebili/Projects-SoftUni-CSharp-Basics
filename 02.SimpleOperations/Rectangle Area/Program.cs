using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var area = a * b;
            Console.WriteLine(area);
        }
    }
}
