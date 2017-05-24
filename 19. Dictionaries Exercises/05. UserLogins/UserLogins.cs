using System;
using System.Collections.Generic;

namespace _05.UserLogins
{
    public class ExamShopping
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var accounts = new Dictionary<string, string>();
            var isLogginPhase = false;
            var countUnsuccessful = 0;
            while (inputList[0] != "end")
            {
                if (inputList[0] == "login")
                {
                    isLogginPhase = true;
                }
                else if (!isLogginPhase)
                {
                    if (accounts.ContainsKey(inputList[0]))
                    {
                        accounts[inputList[0]] = inputList[1];
                    }
                    else
                    {
                        accounts.Add(inputList[0], inputList[1]);
                    }
                }
                else
                {
                    if (accounts.ContainsKey(inputList[0]))
                    {
                        if (inputList[1] == accounts[inputList[0]])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{inputList[0]}: logged in successfully");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{inputList[0]}: login failed");
                            Console.ResetColor();
                            countUnsuccessful++;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{inputList[0]}: login failed");
                        Console.ResetColor();
                        countUnsuccessful++;
                    }
                }
                inputList = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"unsuccessful login attempts: {countUnsuccessful}");
        }
    }
}