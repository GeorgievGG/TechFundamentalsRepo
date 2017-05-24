using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Extramums
{
    public class Extramums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            var goal = Console.ReadLine();
            var maxNum = int.MinValue;
            var minNum = int.MaxValue;
            var result = new List<int>();
            long sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (goal == "Max")
                {
                    for (int j = 0; j < numbers[i].ToString().Length; j++)
                    {
                        if (maxNum < int.Parse(numbers[i]))
                        {
                            maxNum = int.Parse(numbers[i]);
                        }
                        numbers[i] = Rotate(numbers[i]);
                    }
                    result.Add(maxNum);
                    sum += maxNum;
                    maxNum = int.MinValue;
                }
                else if (goal == "Min")
                {
                    for (int j = 0; j < numbers[i].ToString().Length; j++)
                    {
                        if (minNum > int.Parse(numbers[i]))
                        {
                            minNum = int.Parse(numbers[i]);
                        }
                        numbers[i] = Rotate(numbers[i]);
                    }
                    result.Add(minNum);
                    sum += minNum;
                    minNum = int.MaxValue;
                }
            }
            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(sum);
        }

        private static string Rotate(string numString)
        {
            var rotatedNum = new string[numString.Length];
            for (int i = 0; i < numString.Length; i++)
            {
                rotatedNum[i] = numString[(i + 1) % numString.Length].ToString();
            }
            return string.Join("", rotatedNum);
        }
    }
}
