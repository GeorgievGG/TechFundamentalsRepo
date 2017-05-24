using System;
using System.Linq;

namespace _02.ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var command = Console.ReadLine();
            while (command != "end")
            {
                var commandList = command.Split(' ');
                if (commandList[0] == "exchange")
                {
                    inputArray = ExxchangeParts(inputArray, commandList);
                }
                else if (commandList[0] == "max")
                {
                    PrintMaxIndex(inputArray, commandList);
                }
                else if (commandList[0] == "min")
                {
                    PrintMinIndex(inputArray, commandList);
                }
                else if (commandList[0] == "first")
                {
                    PrintFirstElements(inputArray, commandList);
                }
                else if (commandList[0] == "last")
                {
                    PrintLastElements(inputArray, commandList);
                }
                command = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
            Console.ResetColor();
        }

        private static long[] ExxchangeParts(long[] inputArray, string[] commandList)
        {
            var index = int.Parse(commandList[1]);
            if (index >= inputArray.Length || index < 0) //probable error
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Invalid index");
                Console.ResetColor();
            }
            else
            {
                var firstPart = inputArray.Take(index + 1);
                var secPart = inputArray.Skip(index + 1).ToList();
                secPart.AddRange(firstPart);
                inputArray = secPart.ToArray();
            }

            return inputArray;
        }

        private static void PrintMaxIndex(long[] inputArray, string[] commandList)
        {
            var maxIndex = 0;
            var maxNum = 0l;
            if (commandList[1] == "even")
            {
                var evenNums = inputArray.Where(x => x % 2 == 0);
                if (evenNums.Count() != 0)
                {
                    maxNum = evenNums.Max();
                    maxIndex = inputArray.ToList().LastIndexOf(maxNum);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(maxIndex);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No matches");
                    Console.ResetColor();
                }
            }
            else if (commandList[1] == "odd")
            {
                var oddNums = inputArray.Where(x => x % 2 != 0);
                if (oddNums.Count() != 0)
                {
                    maxNum = oddNums.Max();
                    maxIndex = inputArray.ToList().LastIndexOf(maxNum);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(maxIndex);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No matches");
                    Console.ResetColor();
                }
            }
        }


        private static void PrintMinIndex(long[] inputArray, string[] commandList)
        {
            var minIndex = 0;
            var minNum = 0l;
            if (commandList[1] == "even")
            {
                var evenNums = inputArray.Where(x => x % 2 == 0);
                if (evenNums.Count() != 0)
                {
                    minNum = evenNums.Min();
                    minIndex = inputArray.ToList().LastIndexOf(minNum);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(minIndex);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No matches");
                    Console.ResetColor();
                }
            }
            else if (commandList[1] == "odd")
            {
                var oddNums = inputArray.Where(x => x % 2 != 0);
                if (oddNums.Count() != 0)
                {
                    minNum = oddNums.Min();
                    minIndex = inputArray.ToList().LastIndexOf(minNum);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(minIndex);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No matches");
                    Console.ResetColor();
                }
            }
        }
        private static void PrintFirstElements(long[] inputArray, string[] commandList)
        {
            var count = int.Parse(commandList[1]);
            if (count > inputArray.Length)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Invalid count");
                Console.ResetColor();
            }
            else
            {
                if (commandList[2] == "even")
                {
                    var evenNums = inputArray.Where(x => x % 2 == 0).Take(count);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"[{string.Join(", ", evenNums)}]");
                    Console.ResetColor();
                }
                else if (commandList[2] == "odd")
                {
                    var oddNums = inputArray.Where(x => x % 2 != 0).Take(count);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"[{string.Join(", ", oddNums)}]");
                    Console.ResetColor();
                }
            }
        }

        private static void PrintLastElements(long[] inputArray, string[] commandList)
        {
            var count = int.Parse(commandList[1]);
            if (count > inputArray.Length)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Invalid count");
                Console.ResetColor();
            }
            else
            {
                if (commandList[2] == "even")
                {
                    var evenNums = inputArray.Where(x => x % 2 == 0);
                    var lastEvenNums = evenNums.Skip(evenNums.Count() - count).Take(count);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"[{string.Join(", ", lastEvenNums)}]");
                    Console.ResetColor();
                }
                else if (commandList[2] == "odd")
                {
                    var oddNums = inputArray.Where(x => x % 2 != 0);
                    var lastOddNums = oddNums.Skip(oddNums.Count() - count).Take(count);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"[{string.Join(", ", lastOddNums)}]");
                    Console.ResetColor();
                }
            }
        }
    }
}
