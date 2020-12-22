using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "SoftUni";
            //0123456
            //Console.WriteLine(text[0]);
            //Console.WriteLine(text[1]);
            //Console.WriteLine(text[2]);
            //Console.WriteLine(text[3]);
            //Console.WriteLine(text[4]);
            //Console.WriteLine(text[5]);
            //Console.WriteLine(text[6]);

            for (int i = 0; i <=6; i++)
            {
                Console.WriteLine(text[i]);
            }
            string tex = Console.ReadLine();
            for (int i = 0; i < tex.Length; i++) //не трябва да има = за да не отпеч. последния символ
            {
                Console.WriteLine(tex[i]);
            }
            //Math.Pow(6,2) - повдигане на число на степен
        }
    }
}
