using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortArrayWithBubbleSort
{
    public class SortArrayWithBubbleSort
    {
        public static void Main()
        {
            var integerArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var swapped = false;
            var lastUnsortedIndex = integerArray.Length - 1;
            do
            {
                swapped = false;
                for (int i = 0; i < lastUnsortedIndex; i++)
                {
                    if (integerArray[i] > integerArray[i + 1])
                    {
                        integerArray[i] += integerArray[i + 1];
                        integerArray[i + 1] = integerArray[i] - integerArray[i + 1];
                        integerArray[i] = integerArray[i] - integerArray[i + 1];
                    }
                    swapped = true;
                }
                lastUnsortedIndex--;
            }
            while (swapped);
            Console.WriteLine(/*"remaining: " + */string.Join(" ", integerArray));
        }
    }
}
