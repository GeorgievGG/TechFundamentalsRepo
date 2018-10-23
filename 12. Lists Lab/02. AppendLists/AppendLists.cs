using System;
using System.Collections.Generic;

namespace _02.AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            string[] arrays = Console.ReadLine().Split('|');
            List<int> finalNumbers = new List<int>();
            for (int i = 0; i < arrays.Length; i++)
            {
                string[] currentArray = arrays[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<int> currentList = new List<int>();
                for (int j = 0; j < currentArray.Length; j++)
                {
                    currentList.Add(int.Parse(currentArray[j].ToString()));
                }

                AppendToFinalList(finalNumbers, currentList);
            }

            foreach (var number in finalNumbers)
            {
                Console.Write(number + " ");
            }
        }

        private static void AppendToFinalList(List<int> numbers, List<int> currentList)
        {
            currentList.Reverse();
            numbers.Reverse();
            numbers.AddRange(currentList);
            numbers.Reverse();
        }
    }
}
