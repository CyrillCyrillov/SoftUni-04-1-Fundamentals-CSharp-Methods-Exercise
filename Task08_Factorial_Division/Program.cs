using System;

namespace Task08_Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{Faktorial(number1) / Faktorial(number2):f2}");
        }

        private static double Faktorial(int number)
        {
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
