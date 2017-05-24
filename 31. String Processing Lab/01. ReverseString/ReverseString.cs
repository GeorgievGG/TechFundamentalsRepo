using System;
using System.Text;

namespace _01.ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            Console.WriteLine(sb);
        }
    }
}
