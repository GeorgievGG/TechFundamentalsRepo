using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FoldASum
{
    public class FoldASum
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var upper = new List<int>();
            var lower = new List<int>();
            var numsToFold = nums.Count / 4;
            for (int i = 0; i < numsToFold; i++)
            {
                upper.Add(nums[i]);
            }
            upper.Reverse();
            for (int j = nums.Count -1; j >= nums.Count - numsToFold; j--)
            {
                upper.Add(nums[j]);
            }
            for (int li = numsToFold; li < nums.Count - numsToFold; li++)
            {
                lower.Add(nums[li]);
            }
            var sum = upper.Select((x, index) => x + lower[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
