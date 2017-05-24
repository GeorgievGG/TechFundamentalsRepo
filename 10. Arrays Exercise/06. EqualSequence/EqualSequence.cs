using System;
using System.Linq;

namespace _06.EqualSequence
{
    class EqualSequence
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int prevNumber = numbers[0];
            string equalSequence = "Yes";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != prevNumber)
                {
                    equalSequence = "No";
                }
                prevNumber = numbers[i];
            }
            Console.WriteLine(equalSequence);
        }
    }
}
