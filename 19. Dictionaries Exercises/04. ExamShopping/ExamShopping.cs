using System;
using System.Collections.Generic;

namespace _04.ExamShopping
{
    public class ExamShopping
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputList = input.Split(' ');
            var items = new Dictionary<string, long>();
            var isShoppingDay = false;
            while (input != "exam time")
            {
                if (input == "shopping time")
                {
                    isShoppingDay = true;
                }
                if (inputList[0] == "stock")
                {
                    if (items.ContainsKey(inputList[1]))
                    {
                        items[inputList[1]] += long.Parse(inputList[2]);
                    }
                    else
                    {
                        items.Add(inputList[1], long.Parse(inputList[2]));
                    }
                }
                if (inputList[0] == "buy" && isShoppingDay)
                {
                    if (items.ContainsKey(inputList[1]))
                    {
                        if (items[inputList[1]] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{inputList[1]} out of stock");
                            Console.ResetColor();
                        }
                        else
                        {
                            items[inputList[1]] -= Math.Min(long.Parse(inputList[2]), items[inputList[1]]);
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{inputList[1]} doesn't exist");
                        Console.ResetColor();
                    }
                }
                input = Console.ReadLine();
                inputList = input.Split(' ');
            }
            foreach (var kvp in items)
            {
                if (kvp.Value != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
