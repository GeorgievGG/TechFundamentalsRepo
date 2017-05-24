using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.JSONStringify
{
    public class JSONStringify
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var registry = new List<Student>();
            StringBuilder output = new StringBuilder();
            while (input != "stringify")
            {
                var inputList = input.Split(new char[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                registry.Add(new Student(inputList[0], int.Parse(inputList[1]), inputList.Skip(2).Select(int.Parse).ToList()));
                input = Console.ReadLine();
            }
            output.Append("[");
            foreach (var student in registry)
            {
                output.Append("{name:\"" + student.Name + "\",age:" + student.Age + ",grades:[" + string.Join(", ", student.Grades) + "]},");
            }
            output.Append("]");
            output.Remove(output.ToString().LastIndexOf(','), 1);
            Console.WriteLine(output);
        }
    }
    public class Student
    {
        public Student (string name, int age, List<int> grades)
        {
            this.Name = name;
            this.Age = age;
            this.Grades = grades;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }
}
