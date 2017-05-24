using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Phone
    {
        static void Main()
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
                if (request[0] == "call")
                {
                    Call(names, phoneNumbers, request[1]);
                }
                else if (request[0] == "message")
                {
                    Message(names, phoneNumbers, request[1]);
                }
            }
        }
        public static void Call(string[] names, string[] phoneNumbers, string request)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (request == names[i])
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
                else if (request == phoneNumbers[i])
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
            }
        }
        public static void Message(string[] names, string[] phoneNumbers, string request)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (request == names[i])
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
                else if (request == phoneNumbers[i])
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
            }
        }
        public static int GetSumOfDigits(string number)
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
        public static int GetDiffOfDigits(string number)
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
    //public class Phone
    //{
    //    public static void Main()
    //    {
    //        string[] numbers = Console.ReadLine().Split(' ').ToArray();
    //        string[] names = Console.ReadLine().Split(' ').ToArray();
    //        string operation = string.Empty;
    //        string person = string.Empty;

    //        for (;;)
    //        {
    //            string[] newInput = Console.ReadLine().Split(' ').ToArray();

    //            if (newInput[0] == "done")
    //            {
    //                break;
    //            }
    //            else
    //            {
    //                operation = newInput[0];
    //                person = newInput[1];

    //                for (int i = 0; i < names.Length; i++)
    //                {
    //                    if (operation == "call")
    //                    {
    //                        if (person == names[i])
    //                        {
    //                            Console.WriteLine($"calling {numbers[i]}...");

    //                            if (SumOfDigits(numbers[i]) % 2 != 0)
    //                            {
    //                                Console.WriteLine("no answer");
    //                            }
    //                            else if (SumOfDigits(numbers[i]) % 2 == 0)
    //                            {
    //                                Console.WriteLine($"call ended. duration: {SumOfDigits(numbers[i]) / 60:D2}:{SumOfDigits(numbers[i]) % 60:D2}");
    //                            }
    //                        }
    //                        else if (person == numbers[i])
    //                        {
    //                            Console.WriteLine($"calling {names[i]}...");

    //                            if (SumOfDigits(numbers[i]) % 2 != 0)
    //                            {
    //                                Console.WriteLine("no answer");
    //                            }
    //                            else if (SumOfDigits(numbers[i]) % 2 == 0)
    //                            {
    //                                Console.WriteLine($"call ended. duration: {SumOfDigits(numbers[i]) / 60:D2}:{SumOfDigits(numbers[i]) % 60:D2}");
    //                            }
    //                        }
    //                    }
    //                    else if (operation == "message")
    //                    {
    //                        if (person == names[i])
    //                        {
    //                            Console.WriteLine($"sending sms to {numbers[i]}...");

    //                            if (DifferenceOfDigits(numbers[i]) % 2 != 0)
    //                            {
    //                                Console.WriteLine("busy");
    //                            }
    //                            else if (DifferenceOfDigits(numbers[i]) % 2 == 0)
    //                            {
    //                                Console.WriteLine($"meet me there");
    //                            }
    //                        }
    //                        else if (person == numbers[i])
    //                        {
    //                            Console.WriteLine($"sending sms to {names[i]}...");

    //                            if (DifferenceOfDigits(names[i]) % 2 != 0)
    //                            {
    //                                Console.WriteLine("busy");
    //                            }
    //                            else if (DifferenceOfDigits(names[i]) % 2 == 0)
    //                            {
    //                                Console.WriteLine($"meet me there");
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //    }

    //    public static int SumOfDigits(string number)
    //    {
    //        int sum = 0;

    //        for (int i = 0; i < number.Length; i++)
    //        {
    //            if (number[i] >= 48 && number[i] <= 57)
    //            {
    //                int num = int.Parse(number[i].ToString());

    //                if (num >= 0 && num <= 9)
    //                {
    //                    sum += num;
    //                }
    //            }
    //        }

    //        return Math.Abs(sum);
    //    }

    //    public static int DifferenceOfDigits(string number)
    //    {
    //        int diff = 0;

    //        for (int i = 0; i < number.Length; i++)
    //        {
    //            if (number[i] >= 48 && number[i] <= 57)
    //            {
    //                diff = int.Parse(number[i].ToString()) * 2;
    //                break;
    //            }
    //        }

    //        for (int i = 0; i < number.Length; i++)
    //        {
    //            if (number[i] >= 48 && number[i] <= 57)
    //            {
    //                diff -= int.Parse(number[i].ToString());
    //            }
    //        }

    //        return Math.Abs(diff);
    //    }
    //}
}
