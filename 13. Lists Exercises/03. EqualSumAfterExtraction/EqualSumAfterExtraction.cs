using System;
using System.Linq;

namespace _03.EqualSumAfterExtraction
{
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (var num in numbers1)
            {
                numbers2.RemoveAll(x => x == num);
            }
            if (numbers1.Sum() == numbers2.Sum())
            {
                Console.WriteLine($"Yes. Sum: {numbers1.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(numbers1.Sum() - numbers2.Sum())}");
            }
        }
    }
}
