using System;

namespace _07.ResizeableArray
{
    public class ResizeableArray
    {
        public static void Main()
        {
            string[] request = new string[2];
            int?[] numbers = new int?[4];

            while (true)
            {
                request[0] = Console.ReadLine();
                if (request[0].Contains(" "))
                {
                    request = request[0].Split(' ');
                }
                else if (request[0] == "end")
                {
                    break;
                }

                numbers = ExecuteRequest(request, numbers);
            }
            if (numbers.Length == 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                foreach (var element in numbers)
                {
                    if (element != null)
                    {
                        Console.Write(element + " ");
                    }
                }
            }
        }

        private static int?[] ExecuteRequest(string[] request, int?[] numbers)
        {
            if (request[0] == "push")
            {
                numbers = Push(int.Parse(request[1].ToString()), numbers);
            }
            else if (request[0] == "pop")
            {
                numbers = Pop(numbers);
            }
            else if (request[0] == "removeAt")
            {
                numbers = RemoveAt(int.Parse(request[1].ToString()), numbers);
            }
            else if (request[0] == "clear")
            {
                numbers = Clear();
            }

            return numbers;
        }

        private static int?[] Push(int input, int?[] numbers)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (i == numbers.Length)
                {
                    int?[] numbersBackup = new int?[numbers.Length];
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        numbersBackup[j] = numbers[j];
                    }
                    numbers = new int?[numbers.Length + 1];
                    for (int k = 0; k < numbersBackup.Length; k++)
                    {
                        numbers[k] = numbersBackup[k];
                    }
                }
                if (numbers[i] == null)
                {
                    numbers[i] = input;
                    return numbers;
                }
            }
            return numbers;
        }

        private static int?[] Pop(int?[] numbers)
        {
            int?[] poppedNumbers = new int?[numbers.Length - 1];
            int lastFilledIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == null)
                {
                    lastFilledIndex = i - 1;
                    break;
                }
                lastFilledIndex = numbers.Length - 1;
            }
            for (int i = 0; i <= lastFilledIndex - 1; i++)
            {
                poppedNumbers[i] = numbers[i];
            }
            return poppedNumbers;
        }

        private static int?[] RemoveAt(int input, int?[] numbers)
        {
            int?[] numbersNew = new int?[numbers.Length - 1];
            for (int i = 0; i < input; i++)
            {
                numbersNew[i] = numbers[i];
            }
            for (int i = input + 1; i < numbers.Length; i++)
            {
                numbersNew[i - 1] = numbers[i];
            }
            return numbersNew;
        }

        private static int?[] Clear()
        {
            return new int?[0];
        }
    }
}
