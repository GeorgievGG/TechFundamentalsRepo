using System;
using System.Linq;

namespace _06.EqualSequence
{
    public class EqualSequence
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int prevNumber = numbers[0];
            string equalSequence = CheckIfSequenceIsEven(numbers, ref prevNumber);
            Console.WriteLine(equalSequence);
        }

        private static string CheckIfSequenceIsEven(int[] numbers, ref int prevNumber)
        {
            string equalSequence = "Yes";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != prevNumber)
                {
                    equalSequence = "No";
                }
                prevNumber = numbers[i];
            }

            return equalSequence;
        }
    }
}
