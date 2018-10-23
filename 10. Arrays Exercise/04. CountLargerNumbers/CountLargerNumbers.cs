using System;
using System.Linq;

namespace _04.CountLargerNumbers
{
    public class CountLargerNumbers
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double givenNum = double.Parse(Console.ReadLine());
            int countOccurance = CountNumberOccurence(numbers, givenNum);
            Console.WriteLine(countOccurance);
        }

        private static int CountNumberOccurence(double[] numbers, double givenNum)
        {
            int countOccurance = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > givenNum)
                {
                    countOccurance++;
                }
            }

            return countOccurance;
        }
    }
}
