using System;

namespace _01.PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //border -> 1 point ili 2 point
            //1. point	
            //x съвпада с x1 или x2 -> x==x1 || x == x2
            //и 
            //същевременно y е между y1 и y2 -> y >= y1 && y <= y2
            //2. point
            //y съвпада с y1 или y2 -> y == y1 || y == y2
            //и 
            //същевременно x е между x1 и x2 -> x >= x1 && x <= x2
            bool condition1 = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool condition2 = (y == y1 || y == y2) && (x >= x1 && x <= x2);

            if(condition1 || condition2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
