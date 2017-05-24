using System;
using System.Linq;

namespace _05.CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main()
        {
            var input = Console.ReadLine();
            input = input.Replace("...", "$$$$");
            //while (input != "end")
            //{
            //    var sentences = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
            //           .Select(x => x[0].ToString().ToUpper() + string.Join("", x.Skip(1)).ToLower())
            //           .ToList();
            //    foreach (var sentence in sentences)
            //    {
            //        if (sentence != " ")
            //        {
            //            var result = sentence.Split(new char[] { ':', '(', ')', ';', ' ', '-', '.', ',', '\"', '!', '?', '$' }, StringSplitOptions.RemoveEmptyEntries)
            //           .Select(x => x[0].ToString().ToUpper() + string.Join("", x.Skip(1)).ToLower())
            //           .ToList();
            //            Console.WriteLine(string.Join(", ", result));
            //        }
            //    }
            //    input = Console.ReadLine();
            //}
            while (input != "end")
            {
                var result = input.Split(new char[] { ':', '(', ')', ';', ' ', '-', '.', ',', '\"', '!', '?', '$' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => x[0].ToString().ToUpper() + string.Join("", x.Skip(1)).ToLower())
               .ToList();
                Console.WriteLine(string.Join(", ", result));
                input = Console.ReadLine();
            }
        }
    }
}