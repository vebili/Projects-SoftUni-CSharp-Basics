using System;
using System.Drawing;

namespace _02._Exam_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ще получите задача, точки и курс.
            //Всяка задача[1, 2, 3 или 4] има различен коефициент за прилагане върху съответните получени точки.
            //Изчислете какъв финален резултат ще изкара студентът на съответната задача от съответния изпит:
            //Course        "1" "2" "3" "4"
            //Basics         8   9   9   10
            //Fundamentals   11  11  12  13
            //Advanced       14  14  15  16
            //Според курса и задачата има следните допълнителни фактори:
            //•	Ако курсът е "Advanced",  студентът изкарва 20 % повече точки.
            //•	Ако задачата е "1" и курсът е Basics  -20 % по - малко точки.
            //  Вход:
            //•	На първи ред получавате задача: цяло число[1, 4].
            //•	На втори ред получавате точки: цяло число[0 - 100].
            //•	На трети ред получавате курс: string["Basics", "Fundamentals", "Advanced"].
            //Изход:
            //•	Принтирайте общия резултат от тази задача. Форматирайте го до втората цифра след десетичния знак.
            //•	"Total points: {точки}"
            int problem = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string course = Console.ReadLine();

            if (course == "Basics")
            {
                if (problem == 1)
                {
                    points = points * 0.08;
                    points -= points * 0.20;
                }
                if (problem == 2)
                {
                    points = points * 0.09;
                }
                if (problem == 3)
                {
                    points = points * 0.09;
                }
                if (problem == 4)
                {
                    points = points * 0.10;
                }
            }
            if (course == "Fundamentals")
            {
                if (problem == 1)
                {
                    points = points * 0.11;
                }
                if (problem == 2)
                {
                    points = points * 0.11;
                }
                if (problem == 3)
                {
                    points = points * 0.12;
                }
                if (problem == 4)
                {
                    points = points * 0.13;
                }
            }
            if (course == "Advanced")
            {
                if (problem == 1)
                {
                    points = points * 0.14;
                    points += points * 0.20;
                }
                if (problem == 2)
                {
                    points = points * 0.14;
                    points += points * 0.20;
                }
                if (problem == 3)
                {
                    points = points * 0.15;
                    points += points * 0.20;
                }
                if (problem == 4)
                {
                    points = points * 0.16;
                    points += points * 0.20;
                }
            }

            Console.WriteLine($"Total points: {points:f2}");
        }
    }
}