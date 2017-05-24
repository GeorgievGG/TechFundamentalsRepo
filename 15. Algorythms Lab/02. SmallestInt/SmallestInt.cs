using System;
using System.Linq;

namespace _02.SmallestInt
{
    class SmallestInt
    {
        public static void Main()
        {
            var integerArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var smallestInt = int.MaxValue;
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (integerArray[i] < smallestInt)
                {
                    smallestInt = integerArray[i];
                }
            }
            Console.WriteLine(smallestInt);
        }
    }
}
