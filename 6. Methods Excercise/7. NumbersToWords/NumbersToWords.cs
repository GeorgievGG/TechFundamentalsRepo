using System;
using System.Text;

namespace _07.NumbersToWords
{
    class NumbersToWords
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            StringBuilder output = new StringBuilder();
            for (int i = 1; i <= numbers; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                bool isValid = CheckIfValid(currentNumber);
                if (isValid)
                {
                    output.Append(CheckIfNegative(currentNumber));
                    switch (getFirstDigit(currentNumber))
                    {
                        case 1: output.Append("one-hundred"); break;
                        case 2: output.Append("two-hundred"); break;
                        case 3: output.Append("three-hundred"); break;
                        case 4: output.Append("four-hundred"); break;
                        case 5: output.Append("five-hundred"); break;
                        case 6: output.Append("six-hundred"); break;
                        case 7: output.Append("seven-hundred"); break;
                        case 8: output.Append("eight-hundred"); break;
                        case 9: output.Append("nine-hundred"); break;
                    }
                    if (currentNumber % 100 != 0)
                    {
                        output.Append(" and ");
                    }
                    if (currentNumber % 100 != 0 && getSecondDigit(currentNumber) * 10 + getThirdDigit(currentNumber) >= 20)
                    {
                        switch (getSecondDigit(currentNumber))
                        {
                            case 2: output.Append("twenty"); break;
                            case 3: output.Append("thirty"); break;
                            case 4: output.Append("fourty"); break;
                            case 5: output.Append("fifty"); break;
                            case 6: output.Append("sixty"); break;
                            case 7: output.Append("seventy"); break;
                            case 8: output.Append("eighty"); break;
                            case 9: output.Append("ninety"); break;
                        }
                        switch (getThirdDigit(currentNumber))
                        {
                            case 1: output.Append(" one"); break;
                            case 2: output.Append(" two"); break;
                            case 3: output.Append(" three"); break;
                            case 4: output.Append(" four"); break;
                            case 5: output.Append(" five"); break;
                            case 6: output.Append(" six"); break;
                            case 7: output.Append(" seven"); break;
                            case 8: output.Append(" eight"); break;
                            case 9: output.Append(" nine"); break;
                        }
                    }
                    else
                    {
                        switch (getSecondDigit(currentNumber) * 10 + getThirdDigit(currentNumber))
                        {
                            case 1: output.Append("one"); break;
                            case 2: output.Append("two"); break;
                            case 3: output.Append("three"); break;
                            case 4: output.Append("four"); break;
                            case 5: output.Append("five"); break;
                            case 6: output.Append("six"); break;
                            case 7: output.Append("seven"); break;
                            case 8: output.Append("eight"); break;
                            case 9: output.Append("nine"); break;
                            case 10: output.Append("ten"); break;
                            case 11: output.Append("eleven"); break;
                            case 12: output.Append("twelve"); break;
                            case 13: output.Append("thirteen"); break;
                            case 14: output.Append("fourteen"); break;
                            case 15: output.Append("fifteen"); break;
                            case 16: output.Append("sixteen"); break;
                            case 17: output.Append("seventeen"); break;
                            case 18: output.Append("eighteen"); break;
                            case 19: output.Append("nineteen"); break;
                            case 20: output.Append("twenty"); break;
                        }
                    }
                    if (i != numbers)
                    {
                        output.Append("\n");
                    }
                }
                else
                {
                    output.Append(InvalidText(currentNumber));
                    if (InvalidText(currentNumber) != "" && i != numbers)
                    {
                        output.Append("\n");
                    }
                }
            }
            Console.WriteLine(output);
        }
        static bool CheckIfValid(int number)
        {
            if (Math.Abs(number) > 999 || Math.Abs(number) < 100)
            {
                return false;
            }
            return true;
        }
        static string InvalidText(int number)
        {
            if (number > 999)
            {
                return "too large";
            }
            else if (number < -999)
            {
                return "too small";
            }
            return "";
        }
        static string CheckIfNegative(int number)
        {
            if (number < 0)
            {
                return "minus ";
            }
            return "";
        }
        static int getFirstDigit(int number)
        {
            return int.Parse(Math.Abs(number).ToString()[0].ToString());
        }
        static int getSecondDigit(int number)
        {
            return int.Parse(Math.Abs(number).ToString()[1].ToString());
        }
        static int getThirdDigit(int number)
        {
            return int.Parse(Math.Abs(number).ToString()[2].ToString());
        }
    }
}
