using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            int blacklist = 0;
            int lost = 0;

            while (input != "Report")
            {
                string[] command = input.Split(" ").ToArray();
                string operation = command[0];


                if (operation == "Blacklist")
                {
                    if (list.Contains(command[1]))
                    {
                        int index = list.IndexOf(command[1]);
                        list.RemoveAt(index);
                        list.Insert(index, "Blacklisted");
                        Console.WriteLine($"{command[1]} was blacklisted.");
                        blacklist++;


                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} was not found.");
                    }
                }


                else if (operation == "Error")
                {
                    int index = int.Parse(command[1]);

                    if (index < list.Count && index >= 0)
                    {
                        if (list[index] != "Blacklisted" && list[index] != "Lost")

                        {
                            string name = list[index];
                            list.RemoveAt(index);
                            list.Insert(index, "Lost");
                            //Console.WriteLine(list[index]);
                            Console.WriteLine($"{name} was lost due to an error.");
                            lost++;
                        }
                    }
                }
                else if (operation == "Change")
                {
                    int index = int.Parse(command[1]);
                    string newName = command[2];
                    if (index < list.Count && index >= 0)
                    {
                        string currentName = list[index];
                        list.RemoveAt(index);
                        list.Insert(index, newName);
                        Console.WriteLine($"{currentName} changed his username to {newName}. ");
                    }

                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Blacklisted names: {blacklist} ");
            Console.WriteLine($"Lost names: {lost} ");
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
