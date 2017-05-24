using System.IO;

namespace _05.FolderSize
{
    class FolderSize
    {
        static void Main()
        {
            var dir = Directory.GetFiles("../../../Resources/05. Folder Size/TestFolder");
            var totalMemory = 0l;
            foreach (var fileName in dir)
            {
                var fi = new FileInfo(fileName);
                totalMemory += fi.Length;
            }
            File.AppendAllText("../../../Results/05. Folder Size/result.txt", (totalMemory / 1024m / 1024m).ToString());
        }
    }
}
