using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookWanted = Console.ReadLine();
            int library = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < library; i++)
            {
                string bookSearched = Console.ReadLine();
                counter++;
                if (bookSearched == bookWanted)
                {
                    Console.WriteLine($"You checked {i} books and found it.");
                    break;
                }
                if (counter == library)
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {library} books.");
                    break;

                }

            }
        }
    }
}
