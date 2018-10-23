using System;
using System.Globalization;

namespace _02.HolidaysBetweenTwoDates
{
    public class HolidaysBetweenTwoDates
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            int holidaysCount = CountHolidays(startDate, endDate);

            Console.WriteLine(holidaysCount);
        }

        private static int CountHolidays(DateTime startDate, DateTime endDate)
        {
            int holidaysCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            return holidaysCount;
        }
    }
}
