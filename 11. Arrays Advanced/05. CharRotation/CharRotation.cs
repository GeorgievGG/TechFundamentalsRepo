using System;
using System.Linq;

namespace _05.CharRotation
{
    public class CharRotation
    {
        public static void Main()
        {
            string strInput = Console.ReadLine();
            int[] codes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = "";
            result = ApplyCodes(strInput, codes, result);

            Console.WriteLine(result);
        }

        private static string ApplyCodes(string strInput, int[] codes, string result)
        {
            for (int i = 0; i < strInput.Length; i++)
            {
                int newChar = strInput[i];
                int applicableCode = codes[i];
                newChar = ApplyCode(newChar, applicableCode);

                result += (char)newChar;
            }

            return result;
        }

        private static int ApplyCode(int newChar, int applicableCode)
        {
            bool positionIsEven = applicableCode % 2 == 0;
            if (positionIsEven)
            {
                newChar -= applicableCode;
            }
            else
            {
                newChar += applicableCode;
            }

            return newChar;
        }
    }
}
