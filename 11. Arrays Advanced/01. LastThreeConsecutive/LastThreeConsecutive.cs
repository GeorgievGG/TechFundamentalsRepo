using System;

namespace _01.LastThreeConsecutive
{
    class LastThreeConsecutive
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');
            int repeatedStringPosition = 0;
            int count = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = i; j < strings.Length; j++)
                {
                    if (strings[i] == strings[j])
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                    if (count == 3)
                    {
                        repeatedStringPosition = i;
                    }
                }
                count = 0;
            }
            for (int k = repeatedStringPosition; k < repeatedStringPosition + 3; k++)
            {
                Console.Write($"{strings[k]} ");
            }
        }
    }
}
