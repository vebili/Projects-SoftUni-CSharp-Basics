using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int totalTicketsCount = 0;
            int kidTicketsCount = 0;
            int studentTicketsCount = 0;
            int standardTicketsCount = 0;

            while (name != "Finish")
            {
                int free = int.Parse(Console.ReadLine());

                string ticket = Console.ReadLine();
                int ticketsCounter = 0;

                while (ticket != "End")
                {
                    switch (ticket)
                    {
                        case "kid":
                            kidTicketsCount++;
                            break;
                        case "student":
                            studentTicketsCount++;
                            break;
                        case "standard":
                            standardTicketsCount++;
                            break;
                    }
                    ticketsCounter++;
                    if (ticketsCounter == free)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }

                totalTicketsCount += ticketsCounter;
                double seatsTaken = ticketsCounter * 1.0 / free * 100;
                Console.WriteLine($"{name} - {seatsTaken:f2}% full.");
                name = Console.ReadLine();
            }

            double kidTicketsPerc = kidTicketsCount * 1.0 / totalTicketsCount * 100;
            double standardTicketsPerc = standardTicketsCount * 1.0 / totalTicketsCount * 100;
            double studentTicketsPerc = studentTicketsCount * 1.0 / totalTicketsCount * 100;
                        
            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{studentTicketsPerc:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPerc:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPerc:f2}% kids tickets.");
        }
    }
}
