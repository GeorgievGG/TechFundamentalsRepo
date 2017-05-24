using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02.CriticalBreakpoint
{
    class CriticalBreakpoint
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var lines = new List<Line>();
            while (input != "Break it.")
            {
                var coordinates = input.Split().Select(int.Parse).ToArray();
                lines.Add(new Line(new Point(coordinates[0], coordinates[1]), new Point(coordinates[2], coordinates[3])));
                input = Console.ReadLine();
            }
            long actualCR = 0;
            var changedACR = 0;
            foreach (var line in lines)
            {
                if (line.CriticalRatio != 0 && line.CriticalRatio != actualCR)
                {
                    actualCR = line.CriticalRatio;
                    changedACR++;
                }
            }
            if (changedACR > 1)
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
            else if (changedACR == 0)
            {
                foreach (var line in lines)
                {
                    Console.WriteLine($"Line: [{line.A.X}, {line.A.Y}, {line.B.X}, {line.B.Y}]");
                }
                Console.WriteLine($"Critical Breakpoint: 0");
            }
            else
            {
                foreach (var line in lines)
                {
                    Console.WriteLine($"Line: [{line.A.X}, {line.A.Y}, {line.B.X}, {line.B.Y}]");
                }
                BigInteger criticalBreakpoint = BigInteger.Pow(actualCR, lines.Count) % lines.Count;
                Console.WriteLine($"Critical Breakpoint: {criticalBreakpoint}");
            }
            
        }
    }
    public class Point
    {
        public Point (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Line
    {
        public Line(Point a, Point b)
        {
            this.A = a;
            this.B = b;
        }
        public Point A { get; set; }
        public Point B { get; set; }
        public long CriticalRatio
        {
            get
            {
                return Math.Abs(((long)B.X + B.Y) - ((long)A.X + A.Y));
            }
        }
    }
}
