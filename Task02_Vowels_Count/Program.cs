using System;

namespace Task02_Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int vowelsNumbers = GetVowelsNumbers(inputText);

            Console.WriteLine(vowelsNumbers);
        }

        static int GetVowelsNumbers(string inputText)
        {
            string vowelLetters = "AaEeOoIiUu";
            int vowelsNumbers = 0;
            for (int j = 0; j < inputText.Length; j++)
            {
                char nextLetter = inputText[j];
                if (vowelLetters.Contains(nextLetter))
                {
                    vowelsNumbers += 1;
                }
            }

            return vowelsNumbers;
        }
    }
}
