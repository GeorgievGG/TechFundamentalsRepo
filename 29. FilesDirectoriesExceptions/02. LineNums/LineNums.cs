using System;
using System.IO;

namespace _02.LineNums
{
    class LineNums
    {
        static void Main()
        {
            var text = File.ReadAllLines("../../../Resources/02. Line Numbers/Input.txt");
            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("../../../Results/02. Line Numbers/Output.txt", $"{i + 1}. " + text[i] + Environment.NewLine);
            }
        }
    }
}
