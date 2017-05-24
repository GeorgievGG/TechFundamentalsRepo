using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var coordInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Point firstPt = new Point() { x = coordInput[0], y = coordInput[1] };
            coordInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Point secPt = new Point() { x = coordInput[0], y = coordInput[1] };
            Console.WriteLine(CalcDistance(firstPt, secPt).ToString("f3"));
        }
        public static double CalcDistance (Point firstPt, Point secPoint)
        {
            var a = Math.Abs(firstPt.x - secPoint.x);
            var b = Math.Abs(firstPt.y - secPoint.y);
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
