using System;

namespace _04.Phone
{
    public class Phone
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string[] request = new string[2];
            while (true)
            {
                request[0] = Console.ReadLine();
                if (request[0] != "done")
                {
                    request = request[0].Split(' ');
                }
                else
                {
                    break;
                }

                ExecuteRequest(phoneNumbers, names, request);
            }
        }

        private static void ExecuteRequest(string[] phoneNumbers, string[] names, string[] request)
        {
            if (request[0] == "call")
            {
                Call(names, phoneNumbers, request[1]);
            }
            else if (request[0] == "message")
            {
                Message(names, phoneNumbers, request[1]);
            }
        }

        private static void Call(string[] names, string[] phoneNumbers, string request)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (request == names[i])
                {
                    CallByName(phoneNumbers, i);
                }
                else if (request == phoneNumbers[i])
                {
                    CallByPhoneNum(names, phoneNumbers, i);
                }
            }
        }

        private static void CallByName(string[] phoneNumbers, int i)
        {
            Console.WriteLine($"calling {phoneNumbers[i]}...");
            if (GetSumOfDigits(phoneNumbers[i]) % 2 == 0)
            {
                Console.WriteLine($"call ended. duration: {(GetSumOfDigits(phoneNumbers[i]) / 60):D2}:{GetSumOfDigits(phoneNumbers[i]) % 60:D2}");
            }
            else
            {
                Console.WriteLine("no answer");
            }
        }

        private static void CallByPhoneNum(string[] names, string[] phoneNumbers, int i)
        {
            Console.WriteLine($"calling {names[i]}...");
            if (GetSumOfDigits(phoneNumbers[i]) % 2 == 0)
            {
                Console.WriteLine($"call ended. duration: {(GetSumOfDigits(phoneNumbers[i]) / 60):D2}:{GetSumOfDigits(phoneNumbers[i]) % 60:D2}");
            }
            else
            {
                Console.WriteLine("no answer");
            }
        }

        private static void Message(string[] names, string[] phoneNumbers, string request)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (request == names[i])
                {
                    MessageByName(phoneNumbers, i);
                }
                else if (request == phoneNumbers[i])
                {
                    MessageByPhoneNum(names, phoneNumbers, i);
                }
            }
        }

        private static void MessageByName(string[] phoneNumbers, int i)
        {
            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
            if (GetDiffOfDigits(phoneNumbers[i]) % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
            else
            {
                Console.WriteLine("busy");
            }
        }

        private static void MessageByPhoneNum(string[] names, string[] phoneNumbers, int i)
        {
            Console.WriteLine($"sending sms to {names[i]}...");
            if (GetDiffOfDigits(phoneNumbers[i]) % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
            else
            {
                Console.WriteLine("busy");
            }
        }

        private static int GetSumOfDigits(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                if (digit >= 48 && digit <= 57)
                {
                    sum += int.Parse(digit.ToString());
                }
            }

            return sum;
        }

        private static int GetDiffOfDigits(string number)
        {
            int difference = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= 48 && number[i] <= 57)
                {
                    difference = 2 * int.Parse(number[i].ToString());
                    break;
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= 48 && number[i] <= 57)
                {
                    difference -= int.Parse(number[i].ToString());
                }
            }

            return difference;
        }
    }
}
