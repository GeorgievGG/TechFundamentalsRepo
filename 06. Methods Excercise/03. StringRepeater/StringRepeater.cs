using System;

namespace _03.StringRepeater
{
    public class StringRepeater
    {
        public static void Main()
        {
            string repeatedString = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            RepeatStr(repeatedString, repeats);
        }

        private static void RepeatStr(string str, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Console.Write(str);
            }
        }
    }
}
