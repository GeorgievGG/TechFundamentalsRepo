using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumMinMaxAvg
{
    public class SumMinMaxAvg
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var numbersList = new List<int>();
            {
                for (int number = 0; number < input; number++)
                {
                    numbersList.Add(int.Parse(Console.ReadLine()));
                }
            }
            Console.WriteLine($"Sum = {numbersList.Sum()}");
            Console.WriteLine($"Min = {numbersList.Min()}");
            Console.WriteLine($"Max = {numbersList.Max()}");
            Console.WriteLine($"Average = {numbersList.Average()}");
        }
    }
}
