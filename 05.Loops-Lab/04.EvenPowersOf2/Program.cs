using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //za vsichki chetni stepeni ot 0 do n (0, 2, 4, 6, 8, 10)
            //pechatame 2 na tazi stepen
            for (int power = 0; power <= n; power += 2)
            {
                Console.WriteLine(Math.Pow(2, power));
            }
        }
    }
}
