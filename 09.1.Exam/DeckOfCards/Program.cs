using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vehicles = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = input.Split(", ");
                string command = cmdArgs[0];
                string cardName = cmdArgs[1];
                //int index = int.Parse(cmdArgs[1]);
                //string insertCardName = cmdArgs[2];

                if (command == "Add")
                {
                    if (!vehicles.Contains(cardName))
                    {
                        Console.WriteLine("Card successfully bought");
                        vehicles.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card is already bought");
                    }
                }
                else if (command == "Remove")
                {
                    if (vehicles.Contains(cardName))
                    {
                        Console.WriteLine("Card successfully sold");
                        vehicles.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(cmdArgs[1]);
                    //string insertCardName = cmdArgs[2];

                    if (index < 0 || index > vehicles.Count)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    else
                    {
                        vehicles.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string insertCardName = cmdArgs[2];

                    if (index < 0 || index > vehicles.Count)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    else
                    {
                        if (vehicles.Contains(cardName))
                        {
                            Console.WriteLine("Card is already bought");
                        }
                        else
                        {
                            vehicles.Insert(index, cardName);
                            Console.WriteLine("Card successfully bought");
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(", ", vehicles));
        }
    }
}
