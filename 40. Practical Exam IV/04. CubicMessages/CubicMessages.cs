using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    public class CubicMessages
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "Over!")
            {
                var m = int.Parse(Console.ReadLine());
                var pattern = new StringBuilder().Append(@"^\d+([a-zA-Z]{").Append(m).Append("})[^a-zA-Z]*$").ToString();
                var validateInput = new Regex(pattern);
                var match = validateInput.Match(input);
                if (match.Success)
                {
                    var message = match.Groups[1].Value;
                    var verrificationCode = match.Value.Replace(message, "");
                    var output = new StringBuilder();
                    foreach (var ch in verrificationCode)
                    {
                        var index = 0;
                        if (ch >= 48 && ch <= 57)
                        {
                            index = int.Parse(ch.ToString());
                            if (index >= 0 && index < message.Length)
                            {
                                output.Append(message[index]);
                            }
                            else
                            {
                                output.Append(' ');
                            }
                        }
                        else
                        {
                            output.Append(' ');
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{message} == {output.ToString()}");
                    Console.ResetColor();
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
                input = Console.ReadLine();
            }
        }
    }
}
