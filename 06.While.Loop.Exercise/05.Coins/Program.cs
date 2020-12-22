using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            //double change = double.Parse(Console.ReadLine());
            //change = Math.Floor(change * 100);

            //int counter = 0;
            //if (change >= 200)
            //{
            //    change -= 200;
            //    counter++;
            //}
            //if (change >= 100)
            //{
            //    change -= 100;
            //    counter++;
            //}
            //if (change >= 50)
            //{
            //    change -= 50;
            //    counter++;
            //}
            //if (change >= 20)
            //{
            //    change -= 20;
            //    counter++;
            //}
            //if (change >= 10)
            //{
            //    change -= 10;
            //    counter++;
            //}
            //if (change >= 5)
            //{
            //    change -= 5;
            //    counter++;
            //}
            //if (change >= 2)
            //{
            //    change -= 2;
            //    counter++;
            //}
            //if (change >= 1)
            //{
            //    change -= 1;
            //    counter++;
            //}
            //Console.WriteLine(counter);
            double change = double.Parse(Console.ReadLine());
            change = Math.Floor(change * 100);
            //double moneti = Math.Round((coins - lv) * 100);
            double counter = 0;

            while (change > 0)
            {
                if (change >= 200)
                {
                    counter++;
                    change -= 200;
                }
                else if (change >= 100)
                {
                    counter++;
                    change -= 100;
                }
                else if (change >= 50)
                {
                    counter += 1;
                    change -= 50;
                }
                else if (change >= 20)
                {
                    counter += 1;
                    change -= 20;
                }
                else if (change >= 10)
                {
                    counter += 1;
                    change -= 10;
                }
                else if (change >= 05)
                {
                    counter += 1;
                    change -= 05;
                }
                else if (change >= 02)
                {
                    counter += 1;
                    change -= 02;
                }
                else if (change >= 01)
                {
                    counter += 1;
                    change -= 01;
                    break;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
