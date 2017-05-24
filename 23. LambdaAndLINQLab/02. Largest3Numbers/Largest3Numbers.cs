using System;
using System.Linq;

namespace _02.Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var result = nums.OrderByDescending(x => x).Take(3);
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}
