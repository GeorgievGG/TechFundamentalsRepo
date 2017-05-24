using System;
using System.Linq;

namespace _01.ContainsCheck
{
    public class CheckIfContains
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
