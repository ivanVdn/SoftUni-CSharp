using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Channels;


namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] inputCommand = command.Split();


                switch (inputCommand[0])
                {
                    case "exchange":
                        int index = int.Parse(inputCommand[1]);
                        input = Exchange(input, index);
                        break;
                    case "max":
                        string type = inputCommand[1];
                        PrintOddOrEvenMaxIndex(input, type);
                        break;
                    case "min":
                        type = inputCommand[1];
                        PrintOddOrEvenMinIndex(input, type);
                        break;
                    case "first":
                        index = int.Parse(inputCommand[1]);
                        type = inputCommand[2];
                        PrintFirstEventsOrOddElements(input, index, type);
                        break;
                    case "last":
                        index = int.Parse(inputCommand[1]);
                        type = inputCommand[2];
                        PrintLastEventsOrOddElements(input, index, type);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        static int[] Exchange(int[] input, int index)
        {
            if (index < 0 || index > input.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return input;
            }

            int[] exchangedArr = new int[input.Length];

            int temp = 0;
            for (int i = index + 1; i <= input.Length - 1; i++)
            {
                exchangedArr[temp++] = input[i];
            }

            for (int i = 0; i <= index; i++)
            {
                exchangedArr[temp++] = input[i];
            }

            return exchangedArr;
        }

        static void PrintOddOrEvenMaxIndex(int[] input, string oddOrEven)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = input[i];
                if (IsOddOrEven(oddOrEven, currentNumber))
                {
                    if (currentNumber >= maxNumber)
                    {
                        maxNumber = currentNumber;
                        maxIndex = i;
                    }
                }
            }

            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintOddOrEvenMinIndex(int[] input, string evenOrOdd)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = input[i];
                if (IsOddOrEven(evenOrOdd, currentNumber))
                {
                    if (currentNumber <= minNumber)
                    {
                        minNumber = currentNumber;
                        minIndex = i;
                    }
                }
            }

            if (minIndex != -1)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintFirstEventsOrOddElements(int[] input, int index, string type)
        {
            if (InvalidCount(input, index)) return;

            int counter = 0;
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = input[i];
                if (IsOddOrEven(type, currentNumber))
                {

                    output += (currentNumber + ", ");//

                    counter++;
                    if (counter == index)
                    {
                        break;
                    }
                }
            }
            
            Console.WriteLine($"[{string.Join("", output).Trim(',',' ')}]");
        }

        static void PrintLastEventsOrOddElements(int[] input, int index, string type)
        {
            if (InvalidCount(input, index)) return;

            int counter = 0;
            string output = "";
            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                int currentNumber = input[i];
                if (IsOddOrEven(type, currentNumber))
                {
                    output = currentNumber + (", " + output);
                    counter++;
                    
                    if (counter == index)
                    {
                        break;
                    }
                }
            }

            output = output.Trim(' ', ',');

            Console.WriteLine($"[{string.Join("", output)}]");
        }


        static bool InvalidCount(int[] input, int index)
        {
            if (index > input.Length)
            {
                Console.WriteLine("Invalid count");
                return true;
            }

            return false;
        }

        static bool IsOddOrEven(string type, int numb)
        {
            return ((type == "odd" && numb % 2 != 0) || (type == "even" && numb % 2 == 0));
        }
    }
}
