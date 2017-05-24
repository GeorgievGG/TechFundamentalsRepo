using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.JSONParse
{
    public class JSONParse
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var registry = new List<Student>();
            while (input.Contains("name:"))
            {
                var nameStartIx = input.IndexOf("name:\"");
                input = input.Substring(nameStartIx + 6, input.Length - (nameStartIx + 6));
                var name = input.Substring(0, input.IndexOf("\""));

                var ageStartIx = input.IndexOf("\",age:");
                input = input.Substring(ageStartIx + 6, input.Length - (ageStartIx + 6));
                var age = int.Parse(input.Substring(0, input.IndexOf(",")));

                var gradesStartIx = input.IndexOf(",grades:[");
                input = input.Substring(gradesStartIx + 9, input.Length - (gradesStartIx + 9));
                var grades = input.Substring(0, input.IndexOf("]")).Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                registry.Add(new Student(name, age, grades));
            }
            for (int i = 0; i < registry.Count; i++)
            {
                if (registry[i].Grades.Count == 0)
                {
                    Console.WriteLine($"{registry[i].Name} : {registry[i].Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{registry[i].Name} : {registry[i].Age} -> {string.Join(", ", registry[i].Grades)}");
                }
            }
            //registry.ForEach(x => Console.WriteLine($"{x.Name} : {x.Age} -> {string.Join(", ", x.Grades)}"));
        }
        public class Student
        {
            public Student(string name, int age, List<int> grades)
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
}
