using System;

namespace _08.ArraySimmetry
{
    public class ArraySimmetry
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');
            string isSymmetric = CheckForSymmetry(strings);
            Console.WriteLine(isSymmetric);
        }

        private static string CheckForSymmetry(string[] strings)
        {
            string isSymmetric = "Yes";
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] != strings[strings.Length - i - 1])
                {
                    isSymmetric = "No";
                }
            }

            return isSymmetric;
        }
    }
}
