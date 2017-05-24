using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.AverageStudentGrades
{
    public class AverageStudentGrades
    {
        public static void Main(string[] args)
        {
            var inputRows = int.Parse(Console.ReadLine());
            var studentGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < inputRows; i++)
            {
                var input = Console.ReadLine().Split(' ');

                AddGradesToDict(studentGrades, input[0], double.Parse(input[1]));
            }
            foreach (var student in studentGrades)
            {
                var gradesOutput = string.Empty;
                foreach (var grade in student.Value)
                {
                    gradesOutput += " " + grade.ToString("f2");
                }
                Console.WriteLine($"{student.Key} ->{gradesOutput/*string.Join(" ", student.Value.Select(p => string.Format("{0:f2}", p)))*/} (avg: {student.Value.Average():f2})");
            }
        }
        private static void AddGradesToDict(Dictionary<string, List<double>> studentGrades, string name, double grade)
        {
            if (!studentGrades.ContainsKey(name))
            {
                studentGrades.Add(name, new List<double>());
                studentGrades[name].Add(grade);
            }
            else
            {
                studentGrades[name].Add(grade);
            }
        }
    }
}
