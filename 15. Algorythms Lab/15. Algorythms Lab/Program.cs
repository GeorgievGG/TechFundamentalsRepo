using System;
using System.Linq;

namespace _15.Algorythms_Lab
{
    class Program
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int searchedInt = int.Parse(Console.ReadLine());
            if (integerList.Contains(searchedInt))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            //Console.WriteLine(/*"remaining: " + */string.Join(" ", grapes));
        }
    }
}
