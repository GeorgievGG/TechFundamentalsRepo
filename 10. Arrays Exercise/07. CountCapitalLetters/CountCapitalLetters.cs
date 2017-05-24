using System;

namespace _07.CountCapitalLetters
{
    class CountCapitalLetters
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');
            int count = 0;
            bool isCapital = true;
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings[i].Length; j++)
                {
                    if (strings[i][j] > 91 || strings[i][j] < 64)
                    {
                        isCapital = false;
                    }
                }
                if (isCapital == true)
                {
                    count++;
                }
                isCapital = true;
            }
            Console.WriteLine(count);
        }
    }
}
