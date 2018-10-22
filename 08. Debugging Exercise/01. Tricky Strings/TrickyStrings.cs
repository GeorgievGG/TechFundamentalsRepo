using System;

namespace _01.Tricky_Strings
{
    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string currentString = string.Empty;
            string result = string.Empty;
            for (int i = 0; i < numberOfStrings - 1; i++)
            {
                currentString = Console.ReadLine();
                result += currentString + delimiter;
            }
            currentString = Console.ReadLine();
            result += currentString;

            Console.WriteLine(result);
        }
    }
}
