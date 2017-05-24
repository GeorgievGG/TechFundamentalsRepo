using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Messages
{
    class Messages
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var users = new Dictionary<string, User>();
            while (input != "exit")
            {
                var inputList = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputList[0] == "register")
                {
                    var newUser = new User();
                    newUser.username = inputList[1];
                    newUser.messages = new List<Message>();
                    users.Add(newUser.username, newUser);
                    input = Console.ReadLine();
                    continue;
                }
                var sder = inputList[0];
                var receiver = inputList[2];
                var message = String.Empty;
                for (int i = 3; i < inputList.Length; i++)
                {
                    message += inputList[i];
                }
                if (users.ContainsKey(sder) && users.ContainsKey(receiver))
                {
                    users[receiver].messages.Add(new Message() { content = message, sender = new User() { messages = new List<Message>(), username = sder } }); 
                }
                input = Console.ReadLine();
            }
            var followedUsers = Console.ReadLine().Split(' ');
            var firstUser = followedUsers[0];
            var secUser = followedUsers[1];
            var messagesFromFirstToSecond = users[secUser].messages.Where(x => x.sender.username == firstUser).Count();
            var messagesFromSecondToFirst = users[firstUser].messages.Where(x => x.sender.username == secUser).Count();
            Console.ForegroundColor = ConsoleColor.Green;
            if (messagesFromFirstToSecond == 0 && messagesFromSecondToFirst == 0)
            {
                Console.WriteLine("No messages");
            }
            else
            {
                for (int i = 0; i < Math.Max(messagesFromSecondToFirst, messagesFromFirstToSecond); i++)
                {
                    if (i < users[secUser].messages.Where(x => x.sender.username == firstUser).Count())
                    {
                        Console.WriteLine($"{users[firstUser].username}: {users[secUser].messages.Where(x => x.sender.username == firstUser).ToList()[i].content}");
                    }
                    if (i < users[firstUser].messages.Where(x => x.sender.username == secUser).Count())
                    {
                        Console.WriteLine($"{users[firstUser].messages.Where(x => x.sender.username == secUser).ToList()[i].content} :{users[secUser].username}");
                    }
                }
            }
            Console.ResetColor();
        }
    }
    class User
    {
        public string username { get; set; }
        public List<Message> messages { get; set; }
    }
    class Message
    {
        public string content { get; set; }
        public User sender { get; set; }
    }
}