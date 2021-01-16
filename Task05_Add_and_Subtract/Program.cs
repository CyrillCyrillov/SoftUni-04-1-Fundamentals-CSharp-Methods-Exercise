using System;

namespace Task05_Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int sum = AddNumbers(number1, number2);
            int substract = Substract(sum, number3);

            Console.WriteLine(substract);
        }

        private static int Substract(int sum, int number3)
        {
            return sum - number3;
        }

        private static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }


    }
}
