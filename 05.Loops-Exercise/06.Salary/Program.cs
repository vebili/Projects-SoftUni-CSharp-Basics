using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //за всеки един таб от 1 до н-тия
            //повтаряме: получаваме име, проверка за санкция, санкционираме
            //-> проверяваме дали има останала заплата
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int tab = 1; tab <= n; tab++)
            {
                string siteName = Console.ReadLine();  //Facebook, Instagram, Reddit
                switch (siteName)
                {
                    case "Facebook":
                        //salary = salary - 150;
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }                
                if (salary <= 0)   //проверка дали е останала заплата
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
