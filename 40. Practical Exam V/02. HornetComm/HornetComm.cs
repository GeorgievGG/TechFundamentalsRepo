using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.HornetComm
{
    class HornetComm
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var pmCheckRegex = new Regex(@"^([0-9]*) <-> ([a-zA-Z0-9]*)$");
            var broadcastCheckRegex = new Regex(@"^([^0-9]*) <-> ([a-zA-Z0-9]*)$");
            var pms = new List<string>();
            var broadcasts = new List<string>();
            while (input != "Hornet is Green")
            {
                var pm = pmCheckRegex.Match(input);
                var broadcast = broadcastCheckRegex.Match(input);
                if (pm.Success)
                {
                    var query1 = pm.Groups[1].Value;
                    var query2 = pm.Groups[2].Value;
                    pms.Add($"{string.Join("", query1.Reverse())} -> {query2}");
                }
                else if (broadcast.Success)
                {
                    var query1 = broadcast.Groups[1].Value;
                    var query2 = broadcast.Groups[2].Value;
                    var frequency = new StringBuilder();
                    foreach (var ch in query2)
                    {
                        if (ch >= 97 && ch <= 122)
                        {
                            frequency.Append(ch.ToString().ToUpper());
                        }
                        else
                        {
                            frequency.Append(ch.ToString().ToLower());
                        }
                    }
                    broadcasts.Add($"{frequency.ToString()} -> {query1}");
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                broadcasts.ToList().ForEach(x => Console.WriteLine($"{x}"));
            }
            Console.WriteLine("Messages:");
            if (pms.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                pms.ToList().ForEach(x => Console.WriteLine($"{x}"));
            }
        }
    }
}
