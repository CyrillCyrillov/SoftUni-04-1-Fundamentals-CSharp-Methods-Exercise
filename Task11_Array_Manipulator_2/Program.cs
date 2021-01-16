using System;
using System.Linq;

namespace Task11_Array_Manipulator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] rawComand = Console.ReadLine().Split().ToArray();
            string comand = string.Empty;
            int index = 0;

            while (rawComand[0] != "end")
            {
                if (rawComand[0] == "exchange")
                {
                    comand = "exchange";
                    index = int.Parse(rawComand[1]);
                    if (index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int[] exchangedArray = ExchangeArray(numbers, index);
                        numbers = exchangedArray;
                    }

                }
                else if (rawComand[0] == "max" && rawComand[1] == "even")
                {
                    comand = "max even";
                    int maxEvenIndex = MaxEvenIndex(numbers);
                    if (maxEvenIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxEvenIndex);
                    }
                }
                else if (rawComand[0] == "max" && rawComand[1] == "odd")
                {
                    comand = "max odd";
                    int maxOddIndex = MaxOddIndex(numbers);
                    if (maxOddIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxOddIndex);
                    }
                }
                else if (rawComand[0] == "min" && rawComand[1] == "even")
                {
                    comand = "min even";
                    int minEvenIndex = MinEvenIndex(numbers);
                    if (minEvenIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minEvenIndex);
                    }
                }
                else if (rawComand[0] == "min" && rawComand[1] == "odd")
                {
                    comand = "min odd";
                    int minOddIndex = MinOddIndex(numbers);
                    if (minOddIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minOddIndex);
                    }
                }
                else if (rawComand[0] == "first" && rawComand[2] == "even")
                {
                    comand = "first even";
                    index = int.Parse(rawComand[1]);
                    if (index < 0 || index > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int[] firstEven = FirstEven(numbers, index);
                        int firstEvenLenght = FirstEvenLenght(numbers, index);
                        //Console.WriteLine($"[{string.Join(", ", firstEven)}]");
                        if(firstEvenLenght == 0)
                            {
                                Console.WriteLine("[]");
                            }
                        else
                            {
                                Console.Write("[");
                                for (int i = 0; i < firstEvenLenght - 1; i++)
                                {
                                    Console.Write($"{firstEven[i]}, ");
                                }
                                Console.WriteLine($"{firstEven[firstEvenLenght - 1]}]");
                            }
                    }
                }
                else if (rawComand[0] == "first" && rawComand[2] == "odd")
                {
                    comand = "first odd";
                    index = int.Parse(rawComand[1]);
                    if (index < 0 || index > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int[] firstOdd = FirstOdd(numbers, index);
                        int firstOddLenght = FirstOddLenght(numbers, index);
                        //Console.WriteLine($"[{string.Join(", ", firstOdd)}]");
                        if(firstOddLenght == 0)
                            {
                                Console.WriteLine("[]");
                            }
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < firstOddLenght - 1; i++)
                            {
                                Console.Write($"{firstOdd[i]}, ");
                            }
                            Console.WriteLine($"{firstOdd[firstOddLenght - 1]}]");
                        }
                    }
                }
                else if (rawComand[0] == "last" && rawComand[2] == "even")
                {
                    comand = "last even";
                    index = int.Parse(rawComand[1]);

                    if (index < 0 || index > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int[] lastEven = LastEven(numbers, index);
                        int lastEvenLenght = LastEvenLenght(numbers, index);
                        //Console.WriteLine($"[{string.Join(", ", lastEven)}]");
                        if(lastEvenLenght == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < lastEvenLenght - 1; i++)
                            {
                                Console.Write($"{lastEven[i]}, ");
                            }
                            Console.WriteLine($"{lastEven[lastEvenLenght - 1]}]");
                        }
                    }
                }
                else if (rawComand[0] == "last" && rawComand[2] == "odd")
                {
                    comand = "last odd";
                    index = int.Parse(rawComand[1]);

                    if (index < 0 || index > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int[] lastOdd = LastOdd(numbers, index);
                        int lastOddLenght = LastOddLenght(numbers, index);
                        //Console.WriteLine($"[{string.Join(", ", lastEven)}]");
                        if(lastOddLenght == 0)
                            {
                                Console.WriteLine("[]");
                            }
                        else if(lastOddLenght == 1)
                        {
                            Console.WriteLine($"[{lastOdd[lastOdd.Length - 1]}]");
                        }
                        else
                            {
                                Console.Write("[");
                                for (int i = 0; i < lastOddLenght - 1; i++)
                                {
                                    Console.Write($"{lastOdd[i]}, ");
                                }
                                Console.WriteLine($"{lastOdd[lastOddLenght - 1]}]");
                            }
                    }
                }

                rawComand = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
        private static int[] ExchangeArray(int[] numbers, int index)
        {
            int[] exchangedArray = new int[numbers.Length];
            int tempIndex = 0;
            for (int i = index + 1; i < numbers.Length; i++)
                {
                    exchangedArray[tempIndex] = numbers[i];
                    tempIndex += 1;
                }
            tempIndex = 0;
            for (int i = numbers.Length - index - 1; i <= numbers.Length - 1; i++)
                {
                    exchangedArray[i] = numbers[tempIndex];
                    tempIndex += 1;
                }
            return exchangedArray;
        }

        private static int MaxEvenIndex(int[] numbers)
        {
            int maxEvenIndex = -1;
            int maxEven = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i] % 2 == 0 && numbers[i] >= maxEven)
                        {
                            maxEvenIndex = i;
                            maxEven = numbers[i];
                        }
                }
            return maxEvenIndex;
        }

        private static int MaxOddIndex(int[] numbers)
        {
            int maxOddIndex = -1;
            int maxOdd = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i] % 2 != 0 && numbers[i] >= maxOdd)
                        {
                            maxOddIndex = i;
                            maxOdd = numbers[i];
                        }
                }
            return maxOddIndex;
        }

        private static int MinEvenIndex(int[] numbers)
        {
            int minEvenIndex = -1;
            int minEven = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] <= minEven)
                {
                    minEvenIndex = i;
                    minEven = numbers[i];
                }
            }
            return minEvenIndex;
        }

        private static int MinOddIndex(int[] numbers)
        {
            int minOddIndex = -1;
            int minOdd = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && numbers[i] <= minOdd)
                {
                    minOddIndex = i;
                    minOdd = numbers[i];
                }
            }
            return minOddIndex;
        }

        private static int[] FirstEven(int[] numbers, int index)
        {
            int[] firstEven = new int[index];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    {
                        firstEven[count] = numbers[i];
                        count += 1;
                    }
                if (count == index)
                    {
                        break;
                    }
            }
            //firstEven = firstEven.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return firstEven;
        }

        private static int FirstEvenLenght(int[] numbers, int index)
        {
            int[] firstEven = new int[index];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    firstEven[count] = numbers[i];
                    count += 1;
                }
                if (count == index)
                {
                    break;
                }
            }
            //firstEven = firstEven.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int firstEvenLenght = count;
            return firstEvenLenght;
        }

        private static int[] FirstOdd(int[] numbers, int index)
        {
            int[] firstOdd = new int[index];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    firstOdd[count] = numbers[i];
                    count += 1;
                }
                if (count == index)
                {
                    break;
                }
            }
            //firstEven = firstEven.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return firstOdd;
        }

        private static int FirstOddLenght(int[] numbers, int index)
        {
            int[] firstOdd = new int[index];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    firstOdd[count] = numbers[i];
                    count += 1;
                }
                if (count == index)
                {
                    break;
                }
            }
            //firstEven = firstEven.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int firstOddLenght = count;
            return firstOddLenght;
        }

        private static int[] LastEven(int[] numbers, int index)
        {
            int[] lastEven = new int[index];
            int count = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    lastEven[count] = numbers[i];
                    count += 1;
                }
                if (count == index)
                {
                    break;
                }
            }

            lastEven = lastEven.Reverse().ToArray();
            //firstEven = firstEven.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return lastEven;
        }

        private static int LastEvenLenght(int[] numbers, int index)
        {
            int[] lastEven = new int[index];
            int count = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    lastEven[count] = numbers[i];
                    count += 1;
                }
                if (count == index)
                {
                    break;
                }
            }

            lastEven = lastEven.Reverse().ToArray();
            //firstEven = firstEven.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int lastEvenLenght = count;
            return lastEvenLenght;
        }

        private static int[] LastOdd(int[] numbers, int index)
        {
            int[] lastOdd = new int[index];
            int count = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0)
                {
                    lastOdd[count] = numbers[i];
                    count += 1;
                }
                if (count == index)
                {
                    break;
                }
            }

            lastOdd = lastOdd.Reverse().ToArray();
            //firstEven = firstEven.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            return lastOdd;
        }

        private static int LastOddLenght(int[] numbers, int index)
        {
            int[] lastOdd = new int[index];
            int count = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0)
                {
                    lastOdd[count] = numbers[i];
                    count += 1;
                }
                if (count == index)
                {
                    break;
                }
            }
            lastOdd = lastOdd.Reverse().ToArray();
            //firstEven = firstEven.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            int lastOddLenght = count;
            return lastOddLenght;
        }
    }
}
