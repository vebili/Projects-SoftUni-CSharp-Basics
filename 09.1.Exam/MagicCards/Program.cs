using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = "";
            List<string> deck = new List<string>();

            while ((command = Console.ReadLine()) != "Ready")
            {
                List<string> tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (tokens[0])
                {
                    case "Add":

                        if (!cards.Contains(tokens[1]))
                        {
                            Console.WriteLine("Card not found.");
                        }
                        else
                        {
                            deck.Add(tokens[1]);
                        }
                        break;

                    case "Insert":

                        if (!cards.Contains(tokens[1]) || int.Parse(tokens[2]) > cards.Count || int.Parse(tokens[2]) < 0)
                        {
                            Console.WriteLine("Error!");
                        }
                        else
                        {
                            deck.Insert(int.Parse(tokens[2]), tokens[1]);
                        }
                        break;

                    case "Remove":
                        if (!deck.Contains(tokens[1]))
                        {
                            Console.WriteLine("Card not found.");
                        }
                        else
                        {
                            deck.Remove(tokens[1]);
                        }
                        break;

                    case "Swap":

                        int card1Index = deck.IndexOf(tokens[1]);
                        int card2Index = deck.IndexOf(tokens[2]);

                        string current = deck[card1Index];
                        deck[card1Index] = deck[card2Index];
                        deck[card2Index] = current;
                        break;
                        //int card1Index = deck.IndexOf(tokens[1]);
                        //int card2Index = deck.IndexOf(tokens[2]);

                        //string current = deck[card1Index];
                        //deck[card1Index] = deck[card2Index];
                        //deck[card2Index] = current;
                        //break;

                    case "Shuffle":
                        deck.Reverse();
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", deck));
        }
    }
}
