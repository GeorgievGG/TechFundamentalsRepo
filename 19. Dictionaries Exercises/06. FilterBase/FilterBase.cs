using System;
using System.Collections.Generic;

namespace _06.FilterBase
{
    public class FilterBase
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputList = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var salaries = new Dictionary<string, double>();
            var demography = new Dictionary<string, int>();
            var positions = new Dictionary<string, string>();
            var salary = 0d;
            var age = 0;
            while (input != "filter base")
            {
                if (int.TryParse(inputList[1], out age))
                {
                    demography.Add(inputList[0], age);
                }
                else if(double.TryParse(inputList[1], out salary))
                {
                    salaries.Add(inputList[0], salary);
                }
                else
                {
                    positions.Add(inputList[0], inputList[1]);
                }
                input = Console.ReadLine();
                inputList = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            switch (Console.ReadLine())
            {
                case "Salary":
                    foreach (var salaryReg in salaries)
                    {
                        Console.WriteLine($"Name: {salaryReg.Key}");
                        Console.WriteLine($"Salary: {salaryReg.Value:f2}");
                        Console.WriteLine("====================");
                    }
                    break;
                case "Position":
                    foreach (var positionReg in positions)
                    {
                        Console.WriteLine($"Name: {positionReg.Key}");
                        Console.WriteLine($"Position: {positionReg.Value}");
                        Console.WriteLine("====================");
                    }
                    break;
                case "Age":
                    foreach (var ageReg in demography)
                    {
                        Console.WriteLine($"Name: {ageReg.Key}");
                        Console.WriteLine($"Age: {ageReg.Value}");
                        Console.WriteLine("====================");
                    }
                    break;

            }
        }
    }
}
