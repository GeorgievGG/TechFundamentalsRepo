using System;
using System.IO;

namespace _04.MergeFiles
{
    class MergeFiles
    {
        static void Main()
        {
            var text1 = File.ReadAllLines("../../../Resources/04. Merge Files/FileOne.txt");
            var text2 = File.ReadAllLines("../../../Resources/04. Merge Files/FileTwo.txt");
            for (int i = 0; i < text1.Length; i++)
            {
                File.AppendAllText("../../../Results/04. Merge Files/result.txt", text1[i] + Environment.NewLine);
                File.AppendAllText("../../../Results/04. Merge Files/result.txt", text2[i] + Environment.NewLine);
            }
        }
    }
}
