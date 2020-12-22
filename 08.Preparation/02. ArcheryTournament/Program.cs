using System;
using System.Linq;

namespace _02._ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] archeryField = Console.ReadLine()
                                     .Split('|')
                                     .Select(int.Parse)
                                     .ToArray();

            int pointsIskren = 0;
            string command = Console.ReadLine();
            while (command != "Game over")
            {
                string[] currentCommand = command.Split('@');
                string instruction = currentCommand[0];

                if (instruction == "Shoot Left")
                {
                    int index = int.Parse(currentCommand[1]);
                    int length = int.Parse(currentCommand[2]);

                    if (0 <= index && index <= archeryField.Length - 1)
                    {
                        while (length != 0)
                        {
                            if (index > 0)
                            {
                                index -= 1;
                                length -= 1;
                            }

                            else if (index == 0)
                            {
                                index = archeryField.Length - 1;
                                length -= 1;
                            }
                        }
                    }

                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    if (archeryField[index] >= 5)
                    {
                        pointsIskren += 5;
                        archeryField[index] -= 5;
                    }

                    else
                    {
                        pointsIskren += archeryField[index];
                        archeryField[index] = 0;
                    }
                }

                else if (instruction == "Shoot Right")
                {
                    int index = int.Parse(currentCommand[1]);
                    int length = int.Parse(currentCommand[2]);

                    if (0 <= index && index <= archeryField.Length - 1)
                    {
                        while (length != 0)
                        {
                            if (index < archeryField.Length - 1)
                            {
                                index += 1;
                                length -= 1;
                            }

                            else if (index == archeryField.Length - 1)
                            {
                                index = 0;
                                length -= 1;
                            }
                        }
                    }

                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    if (archeryField[index] >= 5)
                    {
                        pointsIskren += 5;
                        archeryField[index] -= 5;
                    }

                    else
                    {
                        pointsIskren += archeryField[index];
                        archeryField[index] = 0;
                    }
                }

                else if (instruction == "Reverse")
                {
                    Array.Reverse(archeryField);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" - ", archeryField));
            Console.WriteLine($"Iskren finished the archery tournament with {pointsIskren} points!");
        }
    }
}
