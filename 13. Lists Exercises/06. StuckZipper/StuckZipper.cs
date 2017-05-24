using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StuckZipper
{
    public class StuckZipper
    {
        public static void Main()
        {
            var upperList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var lowerList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var zipper = new List<int>();
            var lowestDigitsCount = int.MaxValue;
            for (int i = 0; i < Math.Max(lowerList.Count, upperList.Count); i++)
            {
                if (i < upperList.Count)
                {
                    if (Math.Abs(upperList[i]).ToString().Length < lowestDigitsCount)
                    {
                        lowestDigitsCount = Math.Abs(upperList[i]).ToString().Length;
                    }
                }
                if (i < lowerList.Count)
                {
                    if (Math.Abs(lowerList[i]).ToString().Length < lowestDigitsCount)
                    {
                        lowestDigitsCount = Math.Abs(lowerList[i]).ToString().Length;
                    }
                }
            }
            for (int i = Math.Max(lowerList.Count, upperList.Count) - 1; i >= 0; i--)
            {
                if (i < lowerList.Count)
                {
                    if (Math.Abs(lowerList[i]).ToString().Length > lowestDigitsCount)
                    {
                        lowerList.RemoveAt(i);
                    }
                }
                if (i < upperList.Count)
                {
                    if (Math.Abs(upperList[i]).ToString().Length > lowestDigitsCount)
                    {
                        upperList.RemoveAt(i);
                    }
                }
            }
            for (int i = 0; i < Math.Max(lowerList.Count, upperList.Count); i++)
            {
                if (i < lowerList.Count)
                {
                    zipper.Add(lowerList[i]);
                }
                if (i < upperList.Count)
                {
                    zipper.Add(upperList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", zipper));
        }
    }
}
