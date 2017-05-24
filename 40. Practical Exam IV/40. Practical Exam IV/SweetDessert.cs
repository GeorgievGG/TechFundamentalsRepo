using System;

namespace _01.SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());
            var totalBatches = 0;
            if (guests % 6 != 0)
            {
                totalBatches = guests / 6 + 1;
            }
            else
            {
                totalBatches = guests / 6;
            }
            var bananasNeededPrice = (long)totalBatches * 2 * bananaPrice;
            var eggsNeededPrice = (long)totalBatches * 4 * eggPrice;
            var berriesNeededPrice = totalBatches * 0.2m * berriesPrice;
            var totalPrice = bananasNeededPrice + eggsNeededPrice + berriesNeededPrice;
            if (totalPrice <= money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else if (totalPrice > money)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(money - totalPrice):f2}lv more."); 
            }
        }
    }
}
