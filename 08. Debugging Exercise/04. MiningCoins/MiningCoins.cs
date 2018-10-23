using System;

namespace _04.MiningCoins
{
    public class MiningCoins
    {
        public static void Main()
        {
            int codes = int.Parse(Console.ReadLine());
            string decryptedString = string.Empty;
            float totalValue = 0;
            for (int i = 1; i <= codes; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int digit1 = number / 100;
                int digit2 = (number % 100) / 10;
                int digit3 = number % 10;
                totalValue += (digit1 + digit2 + digit3) / (float)codes;
                int ASCIIcode = 0;

                if (i % 2 == 0)
                {
                    ASCIIcode = DecryptEvenNumber(digit1, digit2, digit3);
                }
                else
                {
                    ASCIIcode = DecryptOddNumber(digit1, digit2, digit3);
                }
                if ((ASCIIcode >= 65 && ASCIIcode <= 90) || (ASCIIcode >= 97 && ASCIIcode <= 122))
                {
                    decryptedString += (char)ASCIIcode;
                }
            }
            Console.WriteLine("Message: {0}", decryptedString);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }

        private static int DecryptEvenNumber(int digit1, int digit2, int digit3)
        {
            return ((digit1 * 10) + digit3) + digit2;
        }

        private static int DecryptOddNumber(int digit1, int digit2, int digit3)
        {
            return ((digit1 * 10) + digit3) - digit2;
        }
    }
}
