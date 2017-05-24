using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var Registry = new Dictionary<string, Dictionary<DateTime, int>>();
            var i = 0;
            while (input != "end")
            {
                var inputList = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                Registry.Add(inputList[0], new Dictionary<DateTime, int>());
                Registry[inputList[0]].Add(DateTime.Parse(inputList[1], new CultureInfo("bg-BG")), i);
                input = Console.ReadLine();
                i++;
            }
            //if (Registry.Count() >= 5)
            //{
            //    var endResult = Registry.OrderBy(dt => dt.Value.Keys.Single()).ThenByDescending(reg => reg.Value.Values.Single()).Take(5).Reverse();
            //    foreach (var reg in endResult)
            //    {
            //        Console.WriteLine(reg.Key);
            //    }
            //}
            //else
            //{
            var endResult = Registry.OrderBy(dt => dt.Value.Keys.Single()).Take(5).Reverse();
            if (!(Registry.Count() < 5))
            {
                endResult = Registry.OrderBy(dt => dt.Value.Keys.Single()).ThenByDescending(reg => reg.Value.Values.Single()).Take(5).OrderByDescending(dt => dt.Value.Keys.Single());
            }
            else
            {
                endResult = Registry.OrderBy(dt => dt.Value.Keys.Single()).Take(5).Reverse();
            }
            foreach (var reg in endResult)
                {
                    Console.WriteLine(reg.Key);
                }
            //}
        }
    }
}
