using System;

namespace _01.MultiplyEvensByOdds
{
    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int[] evens = new int[number.Length];
            int[] odds = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != '-')
                {
                    if (int.Parse(number[i].ToString()) % 2 == 0)
                    {
                        evens[i] = int.Parse(number[i].ToString());
                    }
                    else
                    {
                        odds[i] = int.Parse(number[i].ToString());
                    }
                }
            }

            int result = SumOfDigits(odds) * SumOfDigits(evens);
            Console.WriteLine(result);
        }

        private static int SumOfDigits(int[] numbers)
        {
            int sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
