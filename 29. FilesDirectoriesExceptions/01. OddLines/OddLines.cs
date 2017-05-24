using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            var text = File.ReadAllLines("../../../Resources/01. Odd Lines/Input.txt");
            for (int i = 1; i < text.Length; i += 2)
            {
                File.AppendAllText("../../../Results/01. Odd Lines/Output.txt", text[i] + Environment.NewLine);
            }
        }
    }
}
