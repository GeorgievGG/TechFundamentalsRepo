using System;

namespace _03.StringRepeater
{
    public class StringRepeater
    {
        public static void Main()
        {
            string repeatedString = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeats; i++)
            {
                RepeatStr(repeatedString, repeats);
            }
        }
        static void RepeatStr(string str, int repeats)
        {
            Console.Write(str);
        }
    }
}
