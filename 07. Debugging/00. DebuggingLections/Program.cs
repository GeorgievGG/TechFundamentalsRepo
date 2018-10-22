using System;

namespace _00.DebuggingLections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(-5 % 2);

            /*call stack - gives info about the executed methods and lines of their execution and delets them after execution
            you can click on the stack twice to see the stack frame (variables)
            F10 next row
            F11 to enter method
            Right button on debugging point, choose conditions to create conditioned breakpoint

            Data inspection - checking the variables' values during execution
            you can add watch to check values that are in the code but not shown in locals
            Immediate window - you can check values immediately through derived expressions
            You can change the data during debugging when you click on the variable
            Autos are chosen by VS variables that are considered more important 
            */
        }
    }
}
