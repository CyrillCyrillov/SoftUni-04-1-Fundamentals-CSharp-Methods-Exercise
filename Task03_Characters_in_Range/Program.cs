using System;

namespace Task03_Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            
            PrintCharacters(begin, end);
        }
        
        static void PrintCharacters(char begin, char end)
        {
            if(begin > end)
            {
                char help = end;
                end = begin;
                begin = help;
            }
            for (int i = begin + 1; i < end; i++)
            {            
                Console.Write($"{(char)i} ");
            }
        }
    }
}
