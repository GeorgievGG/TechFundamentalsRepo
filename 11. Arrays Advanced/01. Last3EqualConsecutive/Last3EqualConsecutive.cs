using System;

namespace _01.Last3EqualConsecutive
{
    class Last3EqualConsecutive
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');
            string lastString = "";
            int repeatedStringPosition = 0;
            int count = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = i; j < strings.Length; j++)
                {
                    if(strings[i] == strings[j])
                    {
                        count++;
                    }
                    if(count == 3)
                    {
                        repeatedStringPosition = i;
                        count == 0;
                    }
                }
            }
            for (int k = i; k < i + 3; k++)
            {
                Console.Write($"stings[i] ");
            }
        }
    }
}
