using System;

namespace _04.BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ще получите начална популация и години. 
            //На всеки 10 пчели се излюпват нови 2 пчели в началото на всяка година. 
            //В края на всяка година 2 на всеки 20 от пчелите загиват.
            //В началото на всяка 5 - та година след излюпването на новите пчели, 
            //5 на всеки 50 пчели напускат кошера, за да основат собствен такъв.
            //Изчислете каква ще бъде популацията на кошера след съответния брой години.
            //Вход:
            //•	На първи ред получавате начална популация: цяло число[1 - 1000].
            //•	На втори ред получавате години: цяло число[1 - 100].
            //Изход:
            //•	Принтирайте популацията на кошера след съответните години.
            //•	"Beehive population: {population}"
            int population = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            for (int i = 1; i <= years; i++)
            {
                population += population / 10 * 2;
                
                while (i % 5 == 0)
                {
                    population -= population / 50 * 5;
                    break;
                }
                population -= population / 20 * 2;
            }
            Console.WriteLine($"Beehive population: {population}");
        }
    }
}
