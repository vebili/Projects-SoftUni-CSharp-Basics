using System;

namespace _01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            comission = comission * 0.01;

            double allEuro = (yuan * 0.15 * 1.76 + bitcoin * 1168) / 1.95;
            double charge = allEuro * comission;
            double result = allEuro - charge;
            Console.WriteLine($"{result:f2}");
        }
    }
}
