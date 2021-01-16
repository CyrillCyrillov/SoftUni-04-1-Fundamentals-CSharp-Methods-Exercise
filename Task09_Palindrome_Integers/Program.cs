using System;

namespace Task09_Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            //bool isPalindrom = true;

            while (inputNumber != "END")
            {
                Console.WriteLine(IsPalindrom(inputNumber).ToString().ToLower());

                inputNumber = Console.ReadLine();
            }
        }

        private static bool IsPalindrom(string inputNumber)
        {
            string inversNumber = string.Empty;
            for (int i = inputNumber.Length - 1; i >= 0; i--)
            {
                inversNumber += inputNumber[i];
            }

            if(inputNumber == inversNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
