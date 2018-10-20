using System;

namespace _1.BlankReceipt
{
    public class BlankReceipt
    {
        public static void Main()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintHeader()
        {
            Console.WriteLine(@"CASH RECEIPT
------------------------------");
        }

        private static void PrintBody()
        {
            Console.WriteLine(@"Charged to____________________
Received by___________________"
        );
        }

        private static void PrintFooter()
        {
            Console.WriteLine(@"------------------------------
© SoftUni"); 
        }
    }
}
