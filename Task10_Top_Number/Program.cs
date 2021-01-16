using System;

namespace Task10_Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopNumber(int i)
        {
            bool isDivisible = false;
            bool isLeastOneOddDigit = false;

            int helpNumber = i;
            
            while (helpNumber != 0)
            {
                int nextDigit = helpNumber % 10;
                if (nextDigit % 2 != 0)
                {
                    isLeastOneOddDigit = true;
                    break;
                }
                helpNumber = helpNumber / 10;
            }

            
            helpNumber = i;
            int sum = 0;
            while (helpNumber != 0)
            {
                int nextDigit = helpNumber % 10;
                sum += nextDigit;
                helpNumber = helpNumber / 10;
            }
            if(sum % 8 == 0)
            {
                isDivisible = true;
            }

            if(isDivisible && isLeastOneOddDigit)
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
