using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Nilapdromes
{
    public class Nilapdromes
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var border = string.Empty;
            var core = string.Empty;
            var nilapdromes = new List<Nilapdrome>();
            while (input != "end")
            {
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input.Substring(0, i + 1) == string.Join("", input.Skip(input.Length - (i + 1))))
                    {
                        border = input.Substring(0, i + 1);
                    }
                    else
                    {
                        continue;
                    }
                }
                if (input.Length > border.Length * 2 && border.Length != 0)
                {
                    core = input.Substring(border.Length, input.Length - 2 * border.Length);
                    nilapdromes.Add(new Nilapdrome(border, core));
                }
                input = Console.ReadLine();
                border = "";
                core = "";
            }
            foreach (var word in nilapdromes)
            {
                Console.WriteLine($"{word.Core}{word.Border}{word.Core}");
            }
        }
    }
    public class Nilapdrome
    {
        public Nilapdrome (string border, string core)
        {
            this.Border = border;
            this.Core = core;
        }
        public string Border { get; set; }
        public string Core { get; set; }
    }
}
