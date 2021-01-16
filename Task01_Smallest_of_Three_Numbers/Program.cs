using System;

namespace _Task01_Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int smallestNumber = GetSmallest(number1, number2, number3);
            Console.WriteLine(smallestNumber);
        }

        static int GetSmallest(int number1, int number2, int number3)
        {
            int result = 0;
            if(number1 <= number2 && number1 <= number3)
            {
                result = number1;
            }
            else if (number2 <= number1 && number2 <= number3)
            {
                result = number2;
            }
            else if(number3 <= number1 && number3 <= number2)
            {
                result = number3;
            }

            return result;
        }
    }
}
