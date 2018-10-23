using System;

namespace _17.CypherRoulette
{
    public class CypherRoulette
    {
        public static void Main()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());
            var cypheredString = "";
            var currentString = "";
            var lastString = "";
            var spins = 0;
            for (int i = 0; i < numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                if (currentString == "spin")
                {
                    i--;
                    spins++;
                }
                else if (spins % 2 == 1)
                {
                    cypheredString = IncludeStringInFront(cypheredString, currentString);
                }
                else if (spins % 2 == 0)
                {
                    cypheredString += AppendStringOnEnd(currentString);
                }
                else
                {
                    cypheredString += AppendStringOnEnd(currentString);
                }
                if (currentString == lastString)
                {
                    cypheredString = EmptyRoulette();
                }
                lastString = currentString;
            }
            PrintCypheredString(numberOfStrings, cypheredString);
        }

        private static string IncludeStringInFront(string cypheredString, string currentString)
        {
            cypheredString = currentString + cypheredString;
            return cypheredString;
        }

        private static string AppendStringOnEnd(string currentString)
        {
            return currentString;
        }

        private static string EmptyRoulette()
        {
            return "";
        }

        private static void PrintCypheredString(int numberOfStrings, string cypheredString)
        {
            if (numberOfStrings != 0)
            {
                Console.WriteLine(cypheredString);
            }
        }
    }
}
