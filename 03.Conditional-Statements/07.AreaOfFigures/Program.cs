using System;

namespace _07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            //square, rectangle, circle или triangle
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
                //Console.WriteLine($"{area:F3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
                //Console.WriteLine($"{area:F3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
                //Console.WriteLine($"{area:F3}");
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = side * height / 2;
                //Console.WriteLine($"{area:F3}");
            }
            Console.WriteLine($"{area:F3}");
        }
    }
}
