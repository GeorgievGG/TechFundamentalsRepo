using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    public class FlipListSides
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                if (numbers.Count % 2 == 1)
                {
                    if (i != 0 && i != numbers.Count - 1 && i != numbers.Count / 2)
                    {
                        numbers[i] = numbers[i] + numbers[numbers.Count - 1 - i];
                        numbers[numbers.Count - 1 - i] = numbers[i] - numbers[numbers.Count - 1 - i];
                        numbers[i] = numbers[i] - numbers[numbers.Count - 1 - i];
                    }
                }
                else
                {
                    if (i != 0 && i != numbers.Count - 1)
                    {
                        numbers[i] = numbers[i] + numbers[numbers.Count - 1 - i];
                        numbers[numbers.Count - 1 - i] = numbers[i] - numbers[numbers.Count - 1 - i];
                        numbers[i] = numbers[i] - numbers[numbers.Count - 1 - i];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
