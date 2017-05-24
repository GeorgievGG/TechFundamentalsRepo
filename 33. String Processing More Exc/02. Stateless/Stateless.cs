using System;

namespace _02.Stateless
{
    public class Stateless
    {
        public static void Main()
        {
            var state = Console.ReadLine();
            while (state != "collapse")
            {
                var fiction = Console.ReadLine();
                while (fiction.Length != 0)
                {
                    state = state.Replace(fiction.ToString(), "");
                    fiction = fiction.Remove(fiction.Length - 1, 1);
                    if (fiction.Length != 0)
                    {
                        fiction = fiction.Remove(0, 1);
                    }
                }
                if (state.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(void)");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(state.Trim());
                    Console.ResetColor();
                }
                state = Console.ReadLine();
            }
        }
    }
}
