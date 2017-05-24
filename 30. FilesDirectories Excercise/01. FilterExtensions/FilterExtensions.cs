using System;
using System.IO;
using System.Linq;

namespace _01.FilterExtensions
{
    class FilterExtensions
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dir = Directory.GetFiles("../../../Exercises-Resource/01. Filter-Extensions/Input");
            foreach (var fileName in dir)
            {
                var fi = new FileInfo(fileName);
                if (fi.Name.Split('.').Contains(input))
                {
                    File.AppendAllText("../../../Exercises-Resource/01. Filter-Extensions/result.txt", fi.Name + Environment.NewLine);
                }
            }
        }
    }
}
