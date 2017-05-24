using System;
using System.Linq;

namespace _03.ReverseArrayInPlace
{
    public class ReverseArrayInPlace
    {
        public static void Main()
        {
            var integerArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < integerArray.Length / 2; i++)
            {
                integerArray[i] += integerArray[integerArray.Length - i - 1];
                integerArray[integerArray.Length - i - 1] = integerArray[i] - integerArray[integerArray.Length - i - 1];
                integerArray[i] = integerArray[i] - integerArray[integerArray.Length - i - 1];
            }
            Console.WriteLine(/*"remaining: " + */string.Join(" ", integerArray));
        }
    }
}
