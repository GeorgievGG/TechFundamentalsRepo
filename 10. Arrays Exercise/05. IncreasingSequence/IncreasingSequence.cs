using System;
using System.Linq;

namespace _05.IncreasingSequence
{
    public class IncreasingSequence
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int prevNumber = int.MinValue;
            string increasing = CheckIfSequenceIsIncreasing(numbers, ref prevNumber);
            Console.WriteLine(increasing);
        }

        private static string CheckIfSequenceIsIncreasing(int[] numbers, ref int prevNumber)
        {
            string increasing = "Yes";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < prevNumber)
                {
                    increasing = "No";
                }

                prevNumber = numbers[i];
            }

            return increasing;
        }
    }
}
