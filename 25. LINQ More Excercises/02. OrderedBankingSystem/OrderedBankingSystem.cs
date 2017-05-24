using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OrderedBankingSystem
{
    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var bankAccounts = new Dictionary<string, Dictionary<string, decimal>>();
            while (input != "end")
            {
                var inputLine = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = inputLine[0];
                var account = inputLine[1];
                var balance = decimal.Parse(inputLine[2]);
                if (!bankAccounts.ContainsKey(bank))
                {
                    bankAccounts.Add(bank, new Dictionary<string, decimal>());
                }
                if (!bankAccounts[bank].ContainsKey(account))
                {
                    bankAccounts[bank].Add(account, balance);
                }
                else
                {
                    bankAccounts[bank][account] += balance;
                }
                input = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            bankAccounts = bankAccounts
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Max())
                .ToDictionary(x => x.Key, x => x.Value.OrderByDescending(y => y.Value).ToDictionary(y => y.Key, y => y.Value));
            foreach (var kvp in bankAccounts.ToList())
            {
                bankAccounts[kvp.Key].ToList().ForEach(x => Console.WriteLine($"{x.Key} -> {x.Value} ({kvp.Key})"));
            }
        }
    }
}
