using System;
using System.Linq;

namespace _07.LargestNElements
{
    public class LargestNElements
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberOfInt = int.Parse(Console.ReadLine());
            integerList.Sort();
            integerList.Reverse();
            for (int i = 0; i < numberOfInt; i++)
            {
                Console.Write($"{integerList[i]} ");
            }
            //Console.WriteLine(/*"remaining: " + */string.Join(" ", grapes));
        }
    }
}
