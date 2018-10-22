using System;

namespace _16.TrickyStrings
{
    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int numOfChars = int.Parse(Console.ReadLine());
            string newString = "";
            string outputString = "";
            for (int i = 0; i < numOfChars - 1; i++)
            {
                newString = Console.ReadLine();
                outputString += FormatString(newString, delimiter);
            }
            newString = Console.ReadLine();
            outputString += newString;
            Console.WriteLine(outputString);
        }

        private static string FormatString(string newString, string delimiter)
        {
            return $"{newString}{delimiter}";
        }
    }
}
