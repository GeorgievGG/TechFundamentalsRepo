using System;

namespace _08.ArraySimmetry
{
    class ArraySimmetry
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');
            string isSymmetric = "Yes";
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] != strings[strings.Length - i - 1])
                {
                    isSymmetric = "No";
                }
            }
            Console.WriteLine(isSymmetric);
        }
    }
}
