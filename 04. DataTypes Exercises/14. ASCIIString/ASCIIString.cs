using System;

namespace _14.ASCIIString
{
    public class ASCIIString
    {
        public static void Main()
        {
            int numOfChars = int.Parse(Console.ReadLine());
            string chars = "";
            for (int i = 0; i < numOfChars; i++)
            {
                char newChar = (char)int.Parse(Console.ReadLine());
                chars += newChar;
            }
            Console.WriteLine(chars);
        }
    }
}