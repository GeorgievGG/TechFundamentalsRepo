using System;
using System.Linq;

namespace _03.CountGivenArrayElement
{
    public class CountGivenArrayElement
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givenNum = int.Parse(Console.ReadLine());
            int countOccurance = CountNumberOccurences(numbers, givenNum);
            Console.WriteLine(countOccurance);
        }

        private static int CountNumberOccurences(int[] numbers, int givenNum)
        {
            int countOccurance = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == givenNum)
                {
                    countOccurance++;
                }
            }

            return countOccurance;
        }
    }
}
