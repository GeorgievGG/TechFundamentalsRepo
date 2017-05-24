using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.IncreasingCrisis
{
    public class IncreasingCrisis
    {
        public static void Main()
        {
            var incomingLists = long.Parse(Console.ReadLine());
            var result = new List<long>();
            var insertPosition = 0;
            var lastUnbrokenPos = 0;
            var broken = false;
            for (int i = 0; i < incomingLists; i++)
            {
                var numbersInput = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
                for (int k = 0; k < result.Count; k++)
                {
                    if (result[k] <= numbersInput[0])
                    {
                        insertPosition = k + 1;
                    }
                }
                for (int j = 0; j < numbersInput.Count; j++)
                {
                    result.Insert(insertPosition + j, numbersInput[j]);
                    if (insertPosition + j != result.Count - 1)
                    {
                        if (result[insertPosition + j + 1] < result[insertPosition + j])
                        {
                            break;
                        }
                    }
                }
                for (int j = 1; j < result.Count; j++)
                {
                    if (result[j] < result[j - 1])
                    {
                        lastUnbrokenPos = j - 1;
                        broken = true;
                        break;
                    }
                }
                if (broken)
                {
                    for (int l = lastUnbrokenPos + 1; l < result.Count; l++)
                    {
                        result.RemoveAt(l);
                        l--;
                    }
                }
                insertPosition = 0;
                lastUnbrokenPos = 0;
                broken = false;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
