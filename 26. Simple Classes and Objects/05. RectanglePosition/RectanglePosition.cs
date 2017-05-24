using System;
using System.Linq;

namespace _06.RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main()
        {
            var coordInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Rectangle firstRect = new Rectangle() { left = coordInput[0], top = coordInput[1], width = coordInput[2], height = coordInput[3] };
            coordInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Rectangle secRect = new Rectangle() { left = coordInput[0], top = coordInput[1], width = coordInput[2], height = coordInput[3] };
            Console.WriteLine(isInside(firstRect, secRect) ? "Inside" : "Not inside");
        }
        public static bool isInside(Rectangle firstRect, Rectangle secRect)
        {
            if (firstRect.left >= secRect.left 
                && firstRect.top <= secRect.top
                && firstRect.Right <= secRect.Right
                && firstRect.Bottom <= secRect.Bottom)
            {
                return true;
            }
            return false;
        }
    }
    public class Rectangle
    {
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public int Right
        {
            get 
            {
                return left + width;
            }
        }

        public int Bottom
        {
            get
            {
                return top + height;
            }
        }
    }
}
