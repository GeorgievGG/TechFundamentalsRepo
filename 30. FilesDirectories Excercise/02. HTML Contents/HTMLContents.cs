using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _02.HTMLContents
{
    class HTMLContents
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var text = new StringBuilder();
            var body = new List<string>();
            var tags = new List<string>();
            var title = string.Empty;
            while (input != "exit")
            {
                var tag = input.Split(' ')[0];
                var content = input.Split(' ')[1];
                if (tag != "title")
                {
                    tags.Add(tag);
                    body.Add(content);
                }
                else
                {
                    title = content;
                }
                input = Console.ReadLine();
            }
            text.Append("<!DOCTYPE html>" + Environment.NewLine);
            text.Append("<html>" + Environment.NewLine);
            text.Append("<head>" + Environment.NewLine);
            text.Append($"\t<title>{title}</title>{Environment.NewLine}");
            text.Append("</head>" + Environment.NewLine);
            text.Append("<body>" + Environment.NewLine);
            for (int i = 0; i < tags.Count; i++)
            {
                text.Append($"\t<{tags[i]}>{body[i]}</{tags[i]}>{Environment.NewLine}");
            }
            text.Append("</body>" + Environment.NewLine);
            Console.WriteLine();
            File.AppendAllText("../../../Exercises-Resource/02. HTML/result.html", text.ToString());
        }
    }
}
