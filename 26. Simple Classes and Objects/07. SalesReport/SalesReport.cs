using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            var sales = int.Parse(Console.ReadLine());
            var salesList = new List<Sale>();
            var salesReport = new Dictionary<string, double>();
            for (int i = 0; i < sales; i++)
            {
                var inputList = Console.ReadLine().Split(' ');
                salesList.Add(new Sale() { town = inputList[0], products = inputList[1], price = double.Parse(inputList[2]), quantity = double.Parse(inputList[3]) });
            }
            for (int i = 0; i < salesList.Count; i++)
            {
                if (!salesReport.ContainsKey(salesList[i].town))
                {
                    salesReport.Add(salesList[i].town, salesList[i].GetTotalSales);
                }
                else
                {
                    salesReport[salesList[i].town] += salesList[i].GetTotalSales;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            salesReport.OrderBy(x => x.Key).ToList().ForEach(x => Console.WriteLine($"{x.Key} -> {x.Value:f2}"));
        }
    }
    public class Sale
    {
        public string town { get; set; }
        public string products { get; set; }
        public double price { get; set; }
        public double quantity { get; set; }

        public double GetTotalSales
        {
            get
            {
                return price * quantity;
            }    
        }
    }
}
