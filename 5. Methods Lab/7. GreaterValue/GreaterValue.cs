﻿using System;

namespace _7.GreaterNum
{
    class GreaterValue
    {
        static void Main()
        {
            var type = Console.ReadLine();
            //switch (type)
            //{
            //    case "int":
            //        var value1 = int.Parse(Console.ReadLine());
            //        var value2 = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"{GetMax(value1, value2)}");
            //        break;
            //    case "char":
            //        var value1 = Console.ReadLine();
            //        var value2 = Console.ReadLine();
            //        Console.WriteLine($"{GetMax(value1, value2)}");
            //        break;
            //    case "string":
            //        var value1 = Console.ReadLine();
            //        var value2 = Console.ReadLine();
            //        Console.WriteLine($"{GetMax(value1, value2)}");
            //        break;
            //    default:
            //        break;
            //}
            if (type == "int")
            {
                var value1 = int.Parse(Console.ReadLine());
                var value2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{GetMax(value1, value2)}");
            }
            else
            {
                var value1 = Console.ReadLine();
                var value2 = Console.ReadLine();
                Console.WriteLine($"{GetMax(value1, value2)}");
            }
        }
        static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
        static char GetMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }
        static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
    }
}
