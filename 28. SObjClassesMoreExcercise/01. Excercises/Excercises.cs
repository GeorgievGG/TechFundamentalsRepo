using System;
using System.Collections.Generic;

namespace _01.Excercises
{
    public class Excercises
    {
        static void Main()
        {
            var input = Console.ReadLine();
            while (input != "go go go")
            {
                var inputList = input.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var newExercise = new Excercise();
                newExercise.topic = inputList[0];
                newExercise.courseName = inputList[1];
                newExercise.judgeContestLink = inputList[2];
                newExercise.problems = new List<string>();
                for (int i = 3; i < inputList.Length; i++)
                {
                    newExercise.problems.Add(inputList[i]);
                }
                input = Console.ReadLine();
                Console.WriteLine($"Exercises: {newExercise.topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{ newExercise.courseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {newExercise.judgeContestLink}");
                for (int i = 1; i <= newExercise.problems.Count; i++)
                {
                    Console.WriteLine($"{i}. {newExercise.problems[i - 1]}");
                }
            }
        }
    }
    public class Excercise
    {
        public string topic { get; set; }
        public string courseName { get; set; }
        public string judgeContestLink { get; set; }
        public List<string> problems { get; set; }
    }
}
