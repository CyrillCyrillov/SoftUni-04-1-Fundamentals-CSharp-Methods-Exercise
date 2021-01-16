using System;
using System.Linq;

namespace Task11_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string comand = string.Empty;
            int index = 0;

            string rowComand = Console.ReadLine();
            
            if(rowComand[0] == 'e')
                {
                    comand = "exchange";
                    //index = int.Parse(rowComand[9]);
                }
            else if(rowComand[0] == 'f' && rowComand[8] == 'e')
                {
                    comand = "first even";
                    
                }
            else if(rowComand[0] == 'f' && rowComand[8] == 'o')
                {
                    comand = "first odd";
                }
            else if(rowComand[1] == 'a' && rowComand[4] == 'e')
                {
                    comand = "max even";
                }
            else if (rowComand[1] == 'a' && rowComand[4] == 'o')
                {
                    comand = "max odd";
                }
            else if (rowComand[1] == 'i' && rowComand[4] == 'e')
                {
                    comand = "min even";
                }
            else if (rowComand[1] == 'i' && rowComand[4] == 'o')
                {
                    comand = "min odd";
                }

            Console.WriteLine(comand);
            //Console.WriteLine(index);
        }

        //static int[] Exchange (int[] numbers, int index)
        //{
            
            //

            //return exchanged[];
        //}
    }
}
