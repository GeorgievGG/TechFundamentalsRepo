using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
//You have been given the task to create classes for several sophisticated animals,
//Create a class Dog which has a Name(string), Age(int) and NumberOfLegs(int),
//Create a class Cat which has a Name(string), Age(int) and IntelligenceQuotient(int),
//Create a class Snake which has a Name(string), Age(int) and CrueltyCoefficient(int),
//Create a method in each class which is called public void ProduceSound(), The method should print on the console a string depending on the class:
//•	If it’s a Dog, you should print “I’m a Distinguishedog, and I will now produce a distinguished sound! Bau Bau,”
//•	It it’s a Cat, you should print “I’m an Aristocat, and I will now produce an aristocratic sound! Myau Myau,”
//•	If it’s a Snake, you should print “I’m a Sophistisnake, and I will now produce a sophisticated sound! Honey, I’m home,”
//Now for the real deal, You will receive several input commands, which will register animals or make them produce sounds, until you receive the command “I’m your Huckleberry”,
//The commands will be in the following format:
//{class} {name} {age} {parameter}
//The class will be either “Dog”, “Cat” or “Snake”, The name will be a simple string, which can contain any ASCII character BUT space, The age will be an integer, The parameter, will be an integer, Depending on the class it would either be number of legs, IQ, or cruelty coefficient,
//Register each animal, and keep them in collections, by your choice, so that you can ACCESS THEM BY NAME, You will most likely need 3 collections, to store the different animals inside them,
//Between the register commands you might receive a command in the following format:
//talk {name}
//You must then make the animal with the given name, produce a sound,

//When you receive the ending command, you should print every animal in the following format:
//•	If it’s a Dog, you should print “Dog: {name}, Age: {age}, Number Of Legs: {numberOfLegs}”
//•	It it’s a Cat, you should print “Cat: {name}, Age: {age}, IQ: {intelligenceQontient}”
//•	If it’s a Snake, you should print “Snake: {name}, Age: {age}, Cruelty: {crueltyCoefficient}”
//Print first the Dogs, then the Cats, and lastly – The Snakes,

    public class Animals
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var cats = new Dictionary<string, Cat>();
            var dogs = new Dictionary<string, Dog>();
            var snakes = new Dictionary<string, Snake>();
            while (input != "I'm your Huckleberry")
            {
                var inputList = input.Split(' ');
                var newCat = new Cat();
                var newDog = new Dog();
                var newSnake = new Snake();

                switch (inputList[0])
                {
                    case "Cat":
                        newCat.name = inputList[1];
                        newCat.age = int.Parse(inputList[2]);
                        newCat.intelligenceCoefficient = int.Parse(inputList[3]);
                        cats.Add(newCat.name, newCat);
                        break;
                    case "Dog":
                        newDog.name = inputList[1];
                        newDog.age = int.Parse(inputList[2]);
                        newDog.numberOfLegs = int.Parse(inputList[3]);
                        dogs.Add(newDog.name, newDog);
                        break;
                    case "Snake":
                        newSnake.name = inputList[1];
                        newSnake.age = int.Parse(inputList[2]);
                        newSnake.crueltyCoefficient = int.Parse(inputList[3]);
                        snakes.Add(newSnake.name, newSnake);
                        break;
                    case "talk":
                        if (cats.ContainsKey(inputList[1]))
                        {
                            cats[inputList[1]].ProduceSound();
                        }
                        else if (dogs.ContainsKey(inputList[1]))
                        {
                            dogs[inputList[1]].ProduceSound();
                        }
                        else if (snakes.ContainsKey(inputList[1]))
                        {
                            snakes[inputList[1]].ProduceSound();
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            dogs.ToList()
                .ForEach(x => Console.WriteLine($"Dog: {x.Value.name}, Age: {x.Value.age}, Number Of Legs: {x.Value.numberOfLegs}"));
            cats.ToList()
                .ForEach(x => Console.WriteLine($"Cat: {x.Value.name}, Age: {x.Value.age}, IQ: {x.Value.intelligenceCoefficient}"));
            snakes.ToList()
                .ForEach(x => Console.WriteLine($"Snake: {x.Value.name}, Age: {x.Value.age}, Cruelty: {x.Value.crueltyCoefficient}"));
            Console.ResetColor();
        }
    }
    public class Cat
    {
        public string name { get; set; }
        public int age { get; set; }
        public int intelligenceCoefficient { get; set; }
        public void ProduceSound()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            Console.ResetColor();
        }
    }
    public class Dog
    {
        public string name { get; set; }
        public int age { get; set; }
        public int numberOfLegs { get; set; }
        public void ProduceSound()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            Console.ResetColor();
        }
    }
    public class Snake
    {
        public string name { get; set; }
        public int age { get; set; }
        public int crueltyCoefficient { get; set; }
        public void ProduceSound()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            Console.ResetColor();
        }
    }
}
