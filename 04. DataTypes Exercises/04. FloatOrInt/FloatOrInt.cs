using System;

namespace _04.FloatOrInt
{
    class FloatOrInt
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            if (number % 1 == 0)
            {
                Console.WriteLine((int)number);
            }
            else
            {
                Console.WriteLine(Math.Round(number));
            }
        }
    }
}
