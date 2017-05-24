using System;
using System.Collections.Generic;

namespace _05.Boxes
{
    class Boxes
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var boxesList = new List<Box>();
            while (input != "end")
            {
                var inputList = input.Split(new char[] { ' ', '|', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var newBox = new Box();
                newBox.UpperLeft = new Point() { x = int.Parse(inputList[0]), y = int.Parse(inputList[1]) };
                newBox.UpperRight = new Point() { x = int.Parse(inputList[2]), y = int.Parse(inputList[3]) };
                newBox.BottomLeft = new Point() { x = int.Parse(inputList[4]), y = int.Parse(inputList[5]) };
                newBox.BottomRight = new Point() { x = int.Parse(inputList[6]), y = int.Parse(inputList[7]) };
                boxesList.Add(newBox);
                input = Console.ReadLine();
            }
            foreach (var box in boxesList)
            {
                Console.WriteLine($"Box: {box.width}, {box.height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter((int)box.width, (int)box.height)}");
                Console.WriteLine($"Area: {Box.CalculateArea((int)box.width, (int)box.height)}");
            }
        }
    }
    public class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }
        public double width
        {
            get
            {
                return Point.CalculateDistance(UpperLeft, UpperRight);
            }
        }
        public double height
        {
            get
            {
                return Point.CalculateDistance(UpperLeft, BottomLeft);
            }
        }
        public static int CalculatePerimeter(int width, int height)
        {
            return 2 * width + 2 * height;
        }
        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }

    }
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public static double CalculateDistance(Point firstPt, Point secPoint)
        {
            var a = Math.Abs(firstPt.x - secPoint.x);
            var b = Math.Abs(firstPt.y - secPoint.y);
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
