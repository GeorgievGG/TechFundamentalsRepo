using System;
using System.Linq;

namespace _02.IntegerInsert
{
    class IntegerInsert
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var currentNumber = int.Parse(input);
                var index = (int)(currentNumber / (Math.Pow(10, currentNumber.ToString().Length - 1)));
                numbers.Insert(index, currentNumber);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
