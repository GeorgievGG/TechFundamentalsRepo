﻿using System;

namespace _07.TerabytesToBits
{
    public class TerabytesToBits
    {
        public static void Main()
        {
            var terabytes = double.Parse(Console.ReadLine());
            decimal bytes = (decimal)terabytes * 1024 * 1024 * 1024 * 1024 * 8;
            Console.WriteLine(Math.Round(bytes, 0));
        }
    }
}
