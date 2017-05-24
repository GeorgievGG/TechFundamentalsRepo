using System;
using System.Linq;

namespace _03.ShortNumsSorted
{
    public class ShortNumsSorted
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = inputList.Where(a => a.Length < 5).Select(a => a.ToLower()).OrderBy(a => a).Distinct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
