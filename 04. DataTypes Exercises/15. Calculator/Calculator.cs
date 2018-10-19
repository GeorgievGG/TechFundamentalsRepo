using System;

namespace _15.Calculator
{
    public class Calculator
    {
        public static void Main()
        {
            int operand1 = int.Parse(Console.ReadLine());
            char operatr = char.Parse(Console.ReadLine());
            int operand2 = int.Parse(Console.ReadLine());
            int result = 0;
            switch (operatr)
            {
                case '-': result = operand1 - operand2; break;
                case '*': result = operand1 * operand2; break;
                case '+': result = operand1 + operand2; break;
                case '/': result = operand1 / operand2; break;
                default: break;
            }
            Console.WriteLine($"{operand1} {operatr} {operand2} = {result}");
        }
    }
}
