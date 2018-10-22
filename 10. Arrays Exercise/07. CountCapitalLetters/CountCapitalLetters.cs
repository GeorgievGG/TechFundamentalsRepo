using System;

namespace _07.CountCapitalLetters
{
    public class CountCapitalLetters
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');
            int count = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                bool isCapital = CheckIfCapitalLetter(strings, i);
                count = CountIfCapitalLetter(count, isCapital);
            }
            Console.WriteLine(count);
        }

        private static bool CheckIfCapitalLetter(string[] strings, int i)
        {
            bool isCapital = true;
            for (int j = 0; j < strings[i].Length; j++)
            {
                if (strings[i][j] > 91 || strings[i][j] < 64)
                {
                    isCapital = false;
                }
            }

            return isCapital;
        }

        private static int CountIfCapitalLetter(int count, bool isCapital)
        {
            if (isCapital == true)
            {
                count++;
            }

            return count;
        }
    }
}
