using System;

namespace _5.SpecialNumbers
{
    public class SpecialNumbers
    {
        public static void Main()
        {
            int incomingLines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= incomingLines; i++)
            {
                int sum = AggregateDigits(i);
                bool special = CheckForSpecial(sum);
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }

        private static int AggregateDigits(int i)
        {
            int currentNumber = i;
            int sum = 0;
            while (currentNumber != 0)
            {
                int currentDigit = currentNumber % 10;
                sum += currentDigit;
                currentNumber = currentNumber / 10;
            }

            return sum;
        }

        private static bool CheckForSpecial(int sum)
        {
            bool special = false;
            if (sum == 5 || sum == 7 || sum == 11)
            {
                special = true;
            }

            return special;
        }
    }
}
