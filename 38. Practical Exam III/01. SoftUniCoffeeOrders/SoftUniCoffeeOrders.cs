using System;
using System.Globalization;
using System.Numerics;

namespace _01.SoftUniCoffeeOrders
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            var ordersIncoming = int.Parse(Console.ReadLine());
            var totalPrice = 0m;
            for (int i = 0; i < ordersIncoming; i++)
            {
                //var pricePerCapsule = decimal.Parse(Console.ReadLine());
                //var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                //var capsulesCount = ulong.Parse(Console.ReadLine());
                //BigInteger intPart = (BigInteger)pricePerCapsule;
                //var decimalPart = pricePerCapsule % 1;
                //var intPrice = intPart * ((ulong)DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsulesCount);
                //var decimalPrice = decimalPart * ((ulong)DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsulesCount);
                //totalIntPrice += intPrice;
                //totalDecimalPrice += decimalPrice;
                //Console.WriteLine($"The price for the coffee is: ${intPrice + (BigInteger)decimalPrice}.{(decimalPrice % 1).ToString("f2").Substring(2, 2
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = int.Parse(Console.ReadLine());
                var price = pricePerCapsule * ((long)DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsulesCount);
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price.ToString("f2")}");
            }
            Console.WriteLine($"Total: ${totalPrice.ToString("f2")}");
            //Console.WriteLine($"Total: ${totalIntPrice + (BigInteger)totalDecimalPrice}.{(totalDecimalPrice % 1).ToString("f2").Substring(2, 2)}");
        }
    }
}
