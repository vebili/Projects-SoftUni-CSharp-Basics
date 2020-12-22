using System;

namespace _05.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int desire_height = int.Parse(Console.ReadLine());

            int starting_height = desire_height - 30;

            int jumps = 0;

            bool is_count_failures = false;

            while (starting_height <= desire_height)
            {
                int height = int.Parse(Console.ReadLine());
                int count_failures = 0;
                for (int i = 0; i < jumps; i++)
                {
                    if (starting_height < height)
                    {
                        starting_height += 5;
                        break;
                    }
                    else
                    {
                        count_failures += 1;
                    }


                }
                if (count_failures == 3)
                {
                    is_count_failures = true;
                    Console.WriteLine($"Tihomir failed at {starting_height}cm after {jumps} jumps.");
                    break;
                }
                else
                {
                    height = int.Parse(Console.ReadLine());
                }
            }
            if (is_count_failures)
            {
                Console.WriteLine($"Tihomir failed at {starting_height}cm after {jumps} jumps.");
                //break;
            }

            if (starting_height > desire_height)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {desire_height}cm after {jumps} jumps.");
            }

        }
    }
}
