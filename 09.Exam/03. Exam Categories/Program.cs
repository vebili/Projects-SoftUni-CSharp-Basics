using System;

namespace _03._Exam_Categories
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ще получите сложност, завъртяност на условието и брой страници. 
            //От тези данни определете каква е категорията на изпита, който са създали за вас Образователният екип.
            //Сложността е определяща за изпита затова това е първият показател, което проверяваме, 
            //а след това завъртяността на условието и накрая броя страници. 
            //Категориите изпити биват следните:
            //тип изпит   сложност завъртяност страници
            //Legacy       >= 80  &&   >= 80  &&  >= 8
            //Master       >= 80  &&  <= 10       аny
            //Hard          any       >= 50  &&  >= 2
            //Regular       any      any         any
            //Easy          <= 30     any         <= 1
            //Elementary    <= 10     any        any
            
            int complexity = int.Parse(Console.ReadLine());
            int rotation = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());

            bool legacy = complexity >= 80 && rotation >= 80 && pages >= 8;
            bool master = complexity >= 80 && rotation <= 10;
            bool hard = rotation >= 50 && pages >= 2;
            //bool regular = complexity > 0 && rotation > 0 && pages > 0;
            bool easy = complexity <= 30 && pages <= 1;
            bool elementary = complexity <= 10;
            if (legacy)
            {
                Console.WriteLine("Legacy");
            }
            else if (master)
            {
                Console.WriteLine("Master");
            }
            else if (hard)
            {
                Console.WriteLine("Hard");
            }
            else if (elementary)
            {
                Console.WriteLine("Elementary");
            }
            else if (easy)
            {
                Console.WriteLine("Easy");
            }
            else
            {
                Console.WriteLine("Regular");
            }
        }
    }
}
