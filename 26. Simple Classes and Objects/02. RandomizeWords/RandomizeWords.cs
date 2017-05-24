using System;
using System.Linq;

namespace _02.RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ');
            var tmp = string.Empty;
            Random rnd = new Random();
            var randomNum = 0;
            for (int i = 0; i < inputList.Length; i++)
            {
                randomNum = rnd.Next(0, inputList.Length);
                tmp = inputList[i];
                inputList[i] = inputList[randomNum];
                inputList[randomNum] = tmp;
            }
            inputList.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
