using System;

namespace _03.SortStringArray
{
    public class SortStringArray
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var temp = "";
            var lastSortedIndex = input.Length - 1;
            while (lastSortedIndex != 0)
            {
                for (int j = 0; j < lastSortedIndex; j++)
                {
                    if (input[j].CompareTo(input[j + 1]) == 1)
                    {
                        temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
                lastSortedIndex--;
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
