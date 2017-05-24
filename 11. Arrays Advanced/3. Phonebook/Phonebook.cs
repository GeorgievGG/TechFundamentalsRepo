using System;

namespace _03.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string request = "";
            while (request != "done")
            {
                request = Console.ReadLine();
                for (int i = 0; i < names.Length; i++)
                {
                    if (request == names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }
            }
        }
    }
}
