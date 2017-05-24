using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var newCommand = Console.ReadLine().Trim();
            while (newCommand != "end")
            {
                if (newCommand.Substring(0, 7) == "reverse")
                {
                    var inputList = newCommand.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var start = int.Parse(inputList[2]);
                    var count = int.Parse(inputList[4]);
                    if (start >= 0 && start < numbers.Count && count >= 0 && start + count <= numbers.Count)
                    {
                        ReversePartOfArray(numbers, start, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (newCommand.Substring(0, 4) == "sort")
                {
                    var inputList = newCommand.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var start = int.Parse(inputList[2]);
                    var count = int.Parse(inputList[4]);
                    if (start >= 0 && start < numbers.Count && count >= 0 && start + count <= numbers.Count)
                    {
                        SortPartOfArray(numbers, start, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (newCommand.Substring(0, 8) == "rollLeft")
                {
                    var inputList = newCommand.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var count = int.Parse(inputList[1]) % numbers.Count;
                    if (count >= 0)
                    {
                        rollLeft(numbers, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (newCommand.Substring(0, 9) == "rollRight")
                {
                    var inputList = newCommand.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var count = int.Parse(inputList[1]) % numbers.Count;
                    if (count >= 0)
                    {
                        rollRight(numbers, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                newCommand = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void ReversePartOfArray(List<string> numbers, int start, int count)
        {
            var tempNum = string.Empty;
            for (int i = 0, j = count - 1; i < count / 2; i++, j -= 2)
            {
                tempNum = numbers[i + start];
                numbers[i + start] = numbers[i + start + j];
                numbers[i + start + j] = tempNum;
            }
            //Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
        private static void SortPartOfArray(List<string> numbers, int start, int count)
        {
            var tempList = numbers.ToList().Skip(start).Take(count).OrderBy(x => x.ToString()).ToArray();

            for (int i = 0; i < count; i++)
            {
                numbers[i + start] = tempList[i];
            }
            //Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void rollLeft(List<string> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
            //Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
        private static void rollRight(List<string> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
            //Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
