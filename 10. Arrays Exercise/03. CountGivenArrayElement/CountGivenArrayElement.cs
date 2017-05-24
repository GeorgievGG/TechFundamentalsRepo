using System;
using System.Linq;

namespace _03.CountGivenArrayElement
{
    class CountGivenArrayElement
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givenNum = int.Parse(Console.ReadLine());
            int countOccurance = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == givenNum)
                {
                    countOccurance++;
                }
            }
            Console.WriteLine(countOccurance);
        }
    }
}
