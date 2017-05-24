using System;
using System.Linq;

namespace _05.CharRotation
{
    class CharRotation
    {
        static void Main()
        {
            string strInput = Console.ReadLine();
            int[] codes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = "";
            for (int i = 0; i < strInput.Length; i++)
            {
                if (codes[i] % 2 == 0)
                {
                    result += (char)(strInput[i] - codes[i]);
                }
                else
                {
                    result += (char)(strInput[i] + codes[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
