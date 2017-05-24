using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.Products
{
    public class Products
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var outputDir = "../../../Exercises-Resource/05. Products/Output/";
            var stockedProducts = File.ReadAllLines(outputDir + "inventory.txt").Select(x => x.Split(' ').ToList()).ToList();
            var inventory = new List<Product>();
            foreach (var item in stockedProducts)
            {
                var newProd = new Product(item[0], item[1], decimal.Parse(item[2]), int.Parse(item[3]));
                if (!(inventory.Select(x => x.name + "$$" + x.type).Contains(newProd.name + "$$" + newProd.type)))
                {
                    inventory.Add(newProd);
                }
                else
                {
                    inventory.Where(x => x.name == newProd.name && x.type == newProd.type).Single().quantity = newProd.quantity;
                    inventory.Where(x => x.name == newProd.name && x.type == newProd.type).Single().price = newProd.price;
                }
            }
            while (input != "exit")
            {
                if (input == "stock")
                {
                    Directory.CreateDirectory(outputDir);
                    File.WriteAllText(outputDir + "inventory.txt", string.Join(Environment.NewLine, inventory.Select(x => x.name + " " + x.type + " " + x.price + " " + x.quantity).ToList()));
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "analyze")
                {
                    var analyzedProducts = File.ReadAllLines(outputDir + "inventory.txt").Select(x => x.Split(' ').ToList()).OrderBy(x => x[1]).ToList();
                    if (analyzedProducts.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("No products stocked");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        analyzedProducts.ForEach(x => Console.WriteLine($"{x[1]}, Product: {x[0]}{Environment.NewLine}Price: ${x[2]}, Amount Left: {x[3]}"));
                        Console.ResetColor();
                    }
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "sales")
                {
                    var sales = new Dictionary<string, decimal>();
                    foreach (var tp in inventory.Select(x => x.type).Distinct())
                    {
                        sales[tp] = inventory.Where(x => x.type == tp).Sum(x => x.price * x.quantity);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    sales.OrderByDescending(x => x.Value).ToList().ForEach(x => Console.WriteLine($"{x.Key}: ${x.Value:f2}"));
                    Console.ResetColor();
                    input = Console.ReadLine();
                    continue;
                }
                var inputList = input.Split(' ');
                var newProd = new Product(inputList[0], inputList[1], decimal.Parse(inputList[2]), int.Parse(inputList[3]));
                if (!(inventory.Select(x => x.name + "$$" + x.type).Contains(newProd.name + "$$" + newProd.type)))
                {
                    inventory.Add(newProd);
                }
                else
                {
                    inventory.Where(x => x.name == newProd.name && x.type == newProd.type).Single().quantity = newProd.quantity;
                    inventory.Where(x => x.name == newProd.name && x.type == newProd.type).Single().price = newProd.price;
                }
                input = Console.ReadLine();
            }
        }
    }
    public class Product
    {
        public Product(string name, string type, decimal price, int quantity)
        {
            this.name = name;
            this.type = type;
            this.price = price;
            this.quantity = quantity;
        }
        public string name { get; set; }
        public string type { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
    }
}
