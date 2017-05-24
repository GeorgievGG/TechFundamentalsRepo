using System;
using System.Linq;

namespace _01.RemoveOddPositionedElements
{
    public class RemoveOddPositionedElements
    {
        public static void Main()
        {
            var inputString = Console.ReadLine().Split(' ').ToList();
            for (int i = inputString.Count(); i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    inputString.RemoveAt(i - 1);
                }
            }
            Console.WriteLine(string.Join("", inputString));
        }
    }
}
