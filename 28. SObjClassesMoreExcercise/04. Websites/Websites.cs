using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Websites
    {
        //You have been tasked to create an ordered database of websites, For the task you will need to create a class Website, which will have a Host, a Domain and Queries,
        //The Host and the Domain are simple strings, 
        //The Queries, is Collections of strings,
        //You will be given several input lines in the following format:
        //{host
        //    } | {domain
        //} | {query1,query2, , ,}
        //Note: There will always be a host and a domain, but there might NOT be ANY queries,
        //The input sequence ends, when you receive the command “end”, Then you must print all websites in the following format:
        //https://www,{host},{domain}/query?=[{query1]&[{query2}]&[query3], , ,
        //In case there are NO queries, just print:
        //https://www,{host},{domain}

        static void Main()
        {
            var input = Console.ReadLine();
            var websitesList = new List<Website>();
            while (input != "end")
            {
                var inputList = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var newSite = new Website();
                newSite.host = inputList[0];
                newSite.domain = inputList[1];
                newSite.querries = new List<string>();
                if (inputList.Length >= 3)
                {
                    var querriesList = inputList[2].Split(',');
                    for (int i = 0; i < querriesList.Length; i++)
                    {
                        newSite.querries.Add("[" + querriesList[i] + "]");
                    }
                }
                websitesList.Add(newSite);
                input = Console.ReadLine();
            }
            foreach (var ws in websitesList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"https://www.{ws.host}.{ws.domain}");
                if (ws.querries.Count != 0)
                {
                    Console.WriteLine($"/query?={string.Join("&", ws.querries)}");
                }
                Console.ResetColor();
            }
        }
    }
    public class Website
    {
        public string host { get; set; }
        public string domain { get; set; }
        public List<string> querries { get; set; }
    }
}
