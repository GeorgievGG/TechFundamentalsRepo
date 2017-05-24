using System;

namespace _1.BlankReceipt
{
    class BlankReceipt
    {
        static void Main()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader()
        {
            Console.WriteLine(@"CASH RECEIPT
------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine(@"Charged to____________________
Received by___________________"
        );
        }
        static void PrintFooter()
        {
            Console.WriteLine(@"------------------------------
© SoftUni"); 
        }
    }
}
