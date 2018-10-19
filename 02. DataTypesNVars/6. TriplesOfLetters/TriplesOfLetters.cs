using System;

namespace _6.TriplesOfLetters
{
    public class TriplesOfLetters
    {
        public static void Main()
        {
            int lettersCount = int.Parse(Console.ReadLine());
            for (int i = 97; i < lettersCount + 97; i++)
            {
                char firstChar = (char)i;
                for (int j = 97; j < lettersCount + 97; j++)
                {
                    char secondChar = (char)j;
                    for (int k = 97; k < lettersCount + 97; k++)
                    {
                        char thirdChar = (char)k;
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
