using System;

namespace _06.IncrementVariable
{
    public class IncrementVariable
    {
        public static void Main()
        {
            var incrementations = int.Parse(Console.ReadLine());
            byte incrementedNumber = 0;
            var countOverflow = 0;
            for (int i = 0; i < incrementations; i++)
            {
                incrementedNumber++;
                if (incrementedNumber == 0)
                {
                    countOverflow++;
                };
            }

            Console.WriteLine(incrementedNumber);
            if (countOverflow != 0)
            {
                Console.WriteLine($"Overflowed {countOverflow} times");
            }
        }
    }
}
