using System;

namespace _04.RotateArray
{
    public class RotateArray
    {
        public static void Main()
        {
            string[] arrayInput = Console.ReadLine().Split(' ');
            Console.Write(arrayInput[arrayInput.Length - 1] + ' ');
            for (int i = 0; i < arrayInput.Length - 1; i++)
            {
                Console.Write(arrayInput[i] + ' ');
            }
        }
    }
}
