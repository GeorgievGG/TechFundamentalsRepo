using System;

namespace _04.RotateArray
{
    class RotateArray
    {
        public static void Main()
        {
            string[] arrayString = Console.ReadLine().Split(' ');
            //string[] rotatedArray = new string[arrayString.Length];
            Console.Write(arrayString[arrayString.Length - 1] + ' ');
            for (int i = 0; i < arrayString.Length - 1; i++)
            {
                Console.Write(arrayString[i] + ' ');
                //	rotatedArray[i] = arrayString[arrayString.Length - i - 1];
            }
            //foreach (var word in rotatedArray)
            //{
            //	Console.Write(word + ' ');
            //}
        }
    }
}
