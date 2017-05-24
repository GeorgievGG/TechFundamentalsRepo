using System;
using System.Linq;

namespace _04.CountLargerNumbers
{
    class CountLargerNumbers
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double givenNum = double.Parse(Console.ReadLine());
            int countOccurance = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > givenNum)
                {
                    countOccurance++;
                }
            }
            Console.WriteLine(countOccurance);
        }
    }
}
