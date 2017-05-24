using System;

namespace _01.Placeholders
{
    public class Placeholders
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "end")
            {
                var inputList = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var words = inputList[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (inputList[0].Contains("{" + i + "}"))
                    {
                        inputList[0] = inputList[0].Replace("{" + i + "}", words[i]);
                    }
                }
                Console.WriteLine(inputList[0]);
                input = Console.ReadLine();
            }
        }
    }
}
