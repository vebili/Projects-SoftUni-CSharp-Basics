using System;

namespace _09.Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                        Console.WriteLine($"{hour}:{minutes}");      //2:37              
                    if (hour == 2 && minutes == 37)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
        }
    }
}
