using System;

namespace _2.CircleSurface
{
    class CircleSurface
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14159265358979323846264338327;
            Console.WriteLine("{0:f12}", (pi * Math.Pow(r, 2)));
            //float e pecizen samo do 6ti znak
            //ne e hubavo da polzvame float kato double
        }
    }
}
