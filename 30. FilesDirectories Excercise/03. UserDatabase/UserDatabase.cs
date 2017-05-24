using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UserDatabase
{
    class UserDatabase
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var isRegistered = false;
            var somebodyLogged = false;
            while (input != "exit")
            {
                var inputList = input.Split(' ');

                if (inputList[0] == "register")
                {
                    isRegistered = CheckIfRegistered(isRegistered, inputList);
                    validateAndInsertRecord(isRegistered, inputList);
                }
                else if (inputList[0] == "login")
                {
                    Login(ref isRegistered, ref somebodyLogged, inputList);
                }
                else if (inputList[0] == "logout")
                {
                    if (!somebodyLogged)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("There is no currently logged in user.");
                        Console.ResetColor();
                    }
                    else
                    {
                        somebodyLogged = false;
                    }
                }
                input = Console.ReadLine();
                isRegistered = false;
            }
        }

        private static void Login(ref bool isRegistered, ref bool somebodyLogged, string[] inputList)
        {
            isRegistered = CheckIfRegistered(isRegistered, inputList);
            if (somebodyLogged == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("There is already a logged in user.");
                Console.ResetColor();
            }
            else if (isRegistered == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("There is no user with the given username.");
                Console.ResetColor();
            }
            //var passwordOfUser = File.ReadAllLines("../../../Exercises-Resource/03. Registry/registry.txt").Where(x => x.Contains(inputList[1]) && x.Length != 0).Single().Split(' ')[1];
            else if (inputList[2] != File.ReadAllLines("../../../Exercises-Resource/03. Registry/registry.txt").Where(x => x.Contains(inputList[1]) && x.Length != 0).Single().Split(' ')[1])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The password you entered is incorrect.");
                Console.ResetColor();
            }
            else
            {
                somebodyLogged = true;
            }
        }

        private static void validateAndInsertRecord(bool isRegistered, string[] inputList)
        {
            if (isRegistered == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The given username already exists.");
                Console.ResetColor();
            }
            else if (inputList[2] != inputList[3])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The two passwords must match.");
                Console.ResetColor();
            }
            else
            {
                File.AppendAllText("../../../Exercises-Resource/03. Registry/registry.txt", $"{inputList[1]} {inputList[2]} {Environment.NewLine}");
            }
        }

        private static bool CheckIfRegistered(bool isRegistered, string[] inputList)
        {
            foreach (var line in File.ReadAllLines("../../../Exercises-Resource/03. Registry/registry.txt"))
            {
                if (line.Contains(inputList[1]))
                {
                    isRegistered = true;
                    break;
                }
            }

            return isRegistered;
        }
    }
}
