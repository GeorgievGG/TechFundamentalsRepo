using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _04.Files
{
    class Files
    {
        static void Main()
        {
            var incomingFiles = int.Parse(Console.ReadLine());
            var filesDict = new Dictionary<string, File>();
            for (int i = 0; i < incomingFiles; i++)
            {
                var newInput = Console.ReadLine().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var root = newInput[0];
                var fileParams = newInput[newInput.Length - 1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var fileName = fileParams[0];
                var extension = fileParams[0].Substring(fileParams[0].LastIndexOf('.') + 1);
                var size = long.Parse(fileParams[1]);
                var newFile = new File(fileName, root, extension, size);
                var id = new StringBuilder().Append(root).Append("&|").Append(fileName).ToString();
                if (!filesDict.ContainsKey(id))
                {
                    filesDict.Add(id, newFile);
                }
                else
                {
                    filesDict[id] = newFile;
                }
            }
            var request = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var reqExtension = request[0];
            var reqRoot = request[2];
            var applicableFiles = filesDict.Values.Where(x => x.Root == reqRoot && x.Extension == reqExtension).OrderByDescending(x => x.Size).ThenBy(x => x.FileName).ToList();
            if (applicableFiles.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                applicableFiles.ForEach(x => Console.WriteLine($"{x.FileName} - {x.Size} KB"));
            }
        }
    }
    public class File
    {
        public File(string fileName, string root, string extension, long size)
        {
            this.FileName = fileName;
            this.Root = root;
            this.Extension = extension;
            this.Size = size;
        }
        public string FileName { get; set; }
        public string Root { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
    }
}