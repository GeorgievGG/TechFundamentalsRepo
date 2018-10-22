using System;

namespace _06.Notification
{
    public class Notification
    {
        public static void Main()
        {
            int operations = int.Parse(Console.ReadLine());
            string result = "";
            string endString = "";
            for (int i = 1; i <= operations; i++)
            {
                result = Console.ReadLine();
                if (result == "success")
                {
                    endString += ShowSuccess(Console.ReadLine(), Console.ReadLine());
                }
                else if (result == "error")
                {
                    endString += ShowError(Console.ReadLine(), int.Parse(Console.ReadLine()));
                }
                if (i != operations && (result == "success" || result == "error"))
                {
                    endString += "\n";
                }
            }
            if (result == "success" || result == "error")
            {
                Console.WriteLine(endString);
            }
        }

        private static string ShowSuccess(string operation, string message)
        {
            return $@"Successfully executed {operation}.
==============================
Message: {message}.";
        }

        private static string ShowError(string operation, int code)
        {
            string reason = "";
            if (code >= 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }

            return $@"Error: Failed to execute {operation}.
==============================
Error Code: {code}.
Reason: {reason}.";
        }

    }
}
