using System;

namespace _01.CountOccurances
{
    public class CountOccurances
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();
            var searched = Console.ReadLine().ToLower();
            var count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var ix = input.IndexOf(searched, i);
                if (ix >= 0)
                {
                    count++;
                    i = ix;
                }
            }
            Console.WriteLine(count);
        }
    }
}
