using System;

namespace _01.CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            var lengthInDays = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var averageLaps = int.Parse(Console.ReadLine());
            var lapLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());
            var competingRunners = Math.Min((long)trackCapacity * lengthInDays, numberOfRunners);
            var totalDistance = competingRunners * averageLaps * lapLength;
            var moneyRaised = totalDistance / 1000 * moneyPerKm;
            Console.WriteLine("Money raised: " + moneyRaised.ToString("f2"));
        }
    }
}
