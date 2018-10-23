using System;

namespace _03.PriceChangeAlert
{
    public class PriceChangeAlert
    {
        public static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            decimal treshhold = decimal.Parse(Console.ReadLine());
            decimal previousPrice = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                decimal currentPrice = decimal.Parse(Console.ReadLine());
                decimal pricesDiffPercentage = GetPercentageDifference(previousPrice, currentPrice);
                bool isSignificantDifference = CheckIfSignificant(treshhold, pricesDiffPercentage);
                string message = FormatMessageText(currentPrice, previousPrice, pricesDiffPercentage, isSignificantDifference);
                Console.WriteLine(message);
                previousPrice = currentPrice;
            }
        }

        private static decimal GetPercentageDifference(decimal lastPrice, decimal currentPrice)
        {
            decimal result = (currentPrice - lastPrice) / lastPrice;

            return result * 100;
        }

        private static bool CheckIfSignificant(decimal treshhold, decimal PricesDiffPercentage)
        {
            if (Math.Abs(treshhold * 100) <= Math.Abs(PricesDiffPercentage))
            {
                return true;
            }

            return false;
        }

        private static string FormatMessageText(decimal currentPrice, decimal previousPrice, decimal PricesDiffPercentage, bool isSignificantDifference)
        {
            string messageText = "";
            if (PricesDiffPercentage == 0)
            {
                messageText = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                messageText = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, PricesDiffPercentage);
            }
            else if (isSignificantDifference && (PricesDiffPercentage < 0))
            {
                messageText = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, PricesDiffPercentage);
            }
            else if (isSignificantDifference && (PricesDiffPercentage > 0))
            {
                messageText = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, PricesDiffPercentage);
            }

            return messageText;
        }
    }
}