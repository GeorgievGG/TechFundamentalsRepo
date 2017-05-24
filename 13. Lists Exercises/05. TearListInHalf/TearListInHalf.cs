using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TearListInHalf
{
    public class TearListInHalf
    {
        public static void Main()
        {
            var lowerList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var upperList = new List<int>();
            for (int i = 0; i < lowerList.Count; i++)
            {
                if (i >= lowerList.Count / 2)
                {
                    upperList.Add(lowerList[i]);
                    lowerList.RemoveAt(i);
                    i--;
                }
            }
            for (int i = upperList.Count - 1; i >= 0; i--)
            {
                lowerList.Insert(i, upperList[i] / 10);
                lowerList.Insert(i + 2, upperList[i] % 10);
            }
            Console.WriteLine(string.Join(" ", lowerList));
        }
    }
}
