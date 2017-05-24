using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ClosestTwoPoint
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var points = int.Parse(Console.ReadLine());
            var pointsList = new List<Point>();
            var minDistance = double.MaxValue;
            var result1 = new Point() { x = 0, y = 0 };
            var result2 = new Point() { x = 0, y = 0 };
            for (int i = 0; i < points; i++)
            {
                var coordInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                pointsList.Add(new Point() { x = coordInput[0], y = coordInput[1] });
            }
            for (int firstPoint = 0; firstPoint < pointsList.Count(); firstPoint++)
            {
                for (int secPoint = firstPoint + 1; secPoint < pointsList.Count(); secPoint++)
                {
                    if (CalcDistance(pointsList[firstPoint], pointsList[secPoint]) < minDistance)
                    {
                        minDistance = CalcDistance(pointsList[firstPoint], pointsList[secPoint]);
                        result1 = pointsList[firstPoint];
                        result2 = pointsList[secPoint];
                    }
                }
            }
            Console.WriteLine(minDistance.ToString("f3"));
            Console.WriteLine($"({result1.x}, {result1. y})");
            Console.WriteLine($"({result2.x}, {result2.y})");
        }
        public static double CalcDistance(Point firstPt, Point secPoint)
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