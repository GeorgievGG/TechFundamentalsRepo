using System;

namespace _3.ExactProduct
{
    public class ExactProduct
    {
        public static void Main()
        {
            int incomingLines = int.Parse(Console.ReadLine());
            decimal num = 0;
            for (int i = 0; i < incomingLines; i++)
            {
                num = num * decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(num);
        }
    }
}
