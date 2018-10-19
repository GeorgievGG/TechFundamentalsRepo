using System;

namespace _16.TrickyStrings
{
    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int numOfChars = int.Parse(Console.ReadLine());
            string outputString = "";
            string newString = "";
            for (int i = 0; i < numOfChars - 1; i++)
            {
                newString = Console.ReadLine();
                outputString += newString;
                outputString += delimiter;
            }
            newString = Console.ReadLine();
            outputString += newString;
            Console.WriteLine(outputString);
        }
    }
}
