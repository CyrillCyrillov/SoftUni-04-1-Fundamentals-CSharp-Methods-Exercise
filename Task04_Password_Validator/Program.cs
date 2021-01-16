using System;

namespace Task04_Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            
            bool isCorectLenght = ChekForLenght(password);
            bool isCorectSymbols = ChekForSymbols(password);
            bool isCorectNumbers = ChekForNumbers(password);
            

            if(isCorectLenght && isCorectNumbers && isCorectSymbols)
            {
                Console.WriteLine("Password is valid");
            }
            
        }

        static bool ChekForLenght(string password)
        {
            bool isCorect = true;
            if(password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isCorect = false;
            }
            return isCorect;
        }

        static bool ChekForNumbers(string password)
        {
            bool isCorect = true;
            int countNumbers = 0;
            for (int i = 0; i < password.Length; i++)
            {
                //char nextChar = password[i];
                if(password[i] >= 48 && password[i] <= 57)
                {
                    countNumbers += 1;
                }
            }
            if(countNumbers < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isCorect = false;
            }

            return isCorect;
        }

        static bool ChekForSymbols(string password)
        {
            bool isCorect = true;
            for (int i = 0; i < password.Length; i++)
            {
                char nextChar = password[i];
                if(nextChar < 48 || (nextChar >= 58 && nextChar <= 64) || (nextChar >= 91 && nextChar <= 60) || nextChar > 122)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isCorect = false;
                    break;
                }
            }

            return isCorect;
        }
    }
}
