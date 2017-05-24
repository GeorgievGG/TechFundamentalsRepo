using System.Collections.Generic;
using System.IO;

namespace _04.ReDirectory
{
    class ReDirectory
    {
        static void Main()
        {
            var inputDir = Directory.GetFiles("../../../Exercises-Resource/04. Re-Directory/Input");
            var outputDir = "../../../Exercises-Resource/04. Re-Directory/Output/";
            var hsExtensions = new HashSet<string>();
            foreach (var file in inputDir)
            {
                var fi = new FileInfo(file);
                Directory.CreateDirectory(outputDir + fi.Extension + "s");
                Directory.Move(fi.FullName, outputDir + fi.Extension + $"s/{fi.Name}");
            }
        }
    }
}
