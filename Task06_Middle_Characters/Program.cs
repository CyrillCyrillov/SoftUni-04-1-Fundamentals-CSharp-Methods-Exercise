using System;

namespace Task06_Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(MidelOfText(text));
            
            //Console.WriteLine("Hello World!");
        }

        private static string MidelOfText(string text)
        {
            if(text.Length % 2 != 0)
            {
                return text[text.Length / 2].ToString();
            }
            else
            {
                return text[(text.Length / 2) - 1].ToString() + text[(text.Length / 2)].ToString();
            }
        }
    }
}
