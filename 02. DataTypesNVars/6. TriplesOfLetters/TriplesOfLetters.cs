using System;

namespace _6.TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 97; i < n + 97; i++)
            {
                for (int j = 97; j < n + 97; j++)
                {
                    for (int k = 97; k < n + 97; k++)
                    {
                        Console.WriteLine("{0}{1}{2} ", (char)i, (char)j, (char)k);
                    }
                }
            }
        }
    }
}
