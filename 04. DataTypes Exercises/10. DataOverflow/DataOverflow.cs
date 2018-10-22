using System;

namespace _10.DataOverflow
{
    public class DataOverflow
    {
        public static void Main()
        {
            var a = ulong.Parse(Console.ReadLine());
            var b = ulong.Parse(Console.ReadLine());
            var bigger = Math.Max(a, b);
            var smaller = Math.Min(a, b);
            string biggerType = FindNumberType(bigger);
            string smallerType = FindNumberType(smaller);
            Console.WriteLine($"bigger type: {biggerType}");
            Console.WriteLine($"smaller type: {smallerType}");
            if (smallerType == "byte")
            {
                Console.WriteLine($"{bigger} can overflow {smallerType} {Math.Round((double)bigger / byte.MaxValue)} times");
            }
            else if (smallerType == "ushort")
            {
                Console.WriteLine($"{bigger} can overflow {smallerType} {Math.Round((double)bigger / ushort.MaxValue)} times");
            }
            else if (smallerType == "uint")
            {
                Console.WriteLine($"{bigger} can overflow {smallerType} {Math.Round((double)bigger / uint.MaxValue)} times");
            }
            else if (smallerType == "ulong")
            {
                Console.WriteLine($"{bigger} can overflow {smallerType} {Math.Round((double)bigger / ulong.MaxValue)} times");
            }
            
        }
        static string FindNumberType(ulong number)
        {
            if (number >= 0 && number <= byte.MaxValue)
            {
                return "byte";
            }
            if (number >= 0 && number <= ushort.MaxValue)
            {
                return "ushort";
            }
            if (number >= 0 && number <= uint.MaxValue)
            {
                return "uint";
            }
            if (number >= 0 && number <= ulong.MaxValue)
            {
                return "ulong";
            }

            return "N//A";
        }
    }
}
