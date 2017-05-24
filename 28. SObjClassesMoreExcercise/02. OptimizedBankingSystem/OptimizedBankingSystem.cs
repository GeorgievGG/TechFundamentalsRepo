using System;
using System.Collections.Generic;
using System.Linq;

//Remember the Ordered Banking System problem? Well, now you have to optimize it with classes.
//Create a class BankAccount which has a Name(string), Bank(string) and Balance(decimal). 
//You will receive several input lines, containing information in the following way:
//{bank} | {accountName} | {accountBalance}
//You need to store every given Account.When you receive the command “end” you must stop the input sequence.
//Then you must print all Accounts, ordered by their balance, in descending order, and then by length of the bank name, in ascending order.
//The accounts must be printed in the following way “{ accountName} -> {balance} ({bank})”.
//Note: Numbers must be printed, exactly as they are entered.No formatting is required.

namespace _02.OptimizedBankingSystem
{
    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var bankAccountsList = new List<BankAccount>();
            while (input != "end")
            {
                var inputList = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var newBA = new BankAccount();
                newBA.name = inputList[1];
                newBA.bank = inputList[0];
                newBA.balance = decimal.Parse(inputList[2]);
                bankAccountsList.Add(newBA);
                input = Console.ReadLine();
            }
            bankAccountsList = bankAccountsList
                .OrderByDescending(x => x.balance)
                .ThenBy(x => x.bank.Length)
                .ToList();
            //.ForEach(x => Console.WriteLine($"{x.name} -> {x.balance} ({x.bank})"));
            foreach (var ba in bankAccountsList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{ba.name} -> {ba.balance} ({ba.bank})");
                Console.ResetColor();
            }
        }
        public class BankAccount
        {
            public string name { get; set; }
            public string bank { get; set; }
            public decimal balance { get; set; }
        }
    }
}
