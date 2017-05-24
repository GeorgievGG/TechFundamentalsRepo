using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SortListWithInsertionSort
{
    public class InsertionSort
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            foreach (var num in integerList)
            {
                result.Insert(0, num);
                for (int i = 0; i < result.Count - 1; i++)
                {
                    if (result[i] > result[i + 1])
                    {
                        result.Insert(i + 2, result[i]);
                        result.RemoveAt(i);
                    }
                }
            }
            Console.WriteLine(/*"remaining: " + */string.Join(" ", result));
        }
    }
}
