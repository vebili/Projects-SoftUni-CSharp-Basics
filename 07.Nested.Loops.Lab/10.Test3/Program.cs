using System;

namespace _10.Test3
{
    class Program
    {
        static void Main(string[] args)
        {            
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hour}:{minutes}");      //2:37              
                    if (hour == 2 && minutes == 37)
                    {
                        return;
                    }
                }                
            }
        }
    }
}
