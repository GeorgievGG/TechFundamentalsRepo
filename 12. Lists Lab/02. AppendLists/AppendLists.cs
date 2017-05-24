using System;
using System.Collections.Generic;

namespace _02.AppendLists
{
    class AppendLists
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('|');
            List<int> currentList = new List<int>();
            List<int> numbers = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                string[] currNum = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < currNum.Length; j++)
                {
                    currentList.Add(int.Parse(currNum[j].ToString()));
                }
                currentList.Reverse();
                numbers.Reverse();
                numbers.AddRange(currentList);
                numbers.Reverse();
                currentList.Clear();
            }
            foreach (var number in numbers)
            {

                Console.Write(number + " ");
            }
        }
    }
}
