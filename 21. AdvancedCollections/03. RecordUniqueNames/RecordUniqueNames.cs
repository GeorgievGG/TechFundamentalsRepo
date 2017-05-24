using System;
using System.Collections.Generic;

namespace _03.RecordUniqueNames
{
    public class RecordUniqueNames
    {
        public static void Main()
        {
            var inputRows = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < inputRows; i++)
            {
                var input = Console.ReadLine();
                names.Add(input);
            }
            foreach (var name in names)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(name);
            }
        }
    }
}
