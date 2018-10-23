using System;

namespace _02.TriangleFormations
{
    public class TriangleFormations
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            bool triangleValidityCondition1 = (a + b > c);
            bool triangleValidityCondition2 = (b + c > a);
            bool triangleValidityCondition3 = (a + c > b);
            bool isValidTriangle = (triangleValidityCondition1 && triangleValidityCondition2 && triangleValidityCondition3);

            if (isValidTriangle)
            {
                Console.WriteLine("Triangle is valid.");
                bool rightTriangleConditionAB = Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
                bool rightTriangleConditionBC = Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2);
                bool rightTriangleConditionAC = Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2);

                if (rightTriangleConditionAB)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (rightTriangleConditionBC)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (rightTriangleConditionAC)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
