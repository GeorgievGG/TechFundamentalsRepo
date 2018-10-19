using System;
using System.Text;

namespace _08.StringEncryption
{
    class StringEncryption
    {
        static void Main()
        {
            int letters = int.Parse(Console.ReadLine());
            char letter = 'a';
            StringBuilder EncryptedString = new StringBuilder();
            for (int i = 0; i < letters; i++)
            {
                letter = char.Parse(Console.ReadLine());
                EncryptedString.Append(Encrypt(letter));
            }
            Console.WriteLine(EncryptedString);
        }
        static string Encrypt(char letter)
        {
            char firstEncryptLetter = (char)(letter + getLastDigit(letter));
            char lastEncryptLetter = (char)(letter - getFirstDigit(letter));
            return firstEncryptLetter.ToString() + getFirstDigit(letter) + getLastDigit(letter) + lastEncryptLetter;
        }
        static int getFirstDigit(int asciiCode)
        {
            return int.Parse(Math.Abs(asciiCode).ToString()[0].ToString());
        }
        static int getLastDigit(int asciiCode)
        {
            return asciiCode % 10;
        }
    }
}
