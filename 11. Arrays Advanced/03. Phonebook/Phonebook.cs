using System;

namespace _03.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string request = "";
            while (request != "done")
            {
                request = GetRequest();
                SearchNumber(phoneNumbers, names, request);
            }
        }

        private static string GetRequest()
        {
            return Console.ReadLine();
        }

        private static void SearchNumber(string[] phoneNumbers, string[] names, string request)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (request == names[i])
                {
                    PrintNumber(phoneNumbers, names, i);
                }
            }
        }

        private static void PrintNumber(string[] phoneNumbers, string[] names, int i)
        {
            Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
        }
    }
}
