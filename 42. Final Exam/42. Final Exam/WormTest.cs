using System;

namespace _42.Final_Exam
{
    //On the first line of input you will get the worm’s length in meters(cm), which will be an integer.
    //On the second line of input you will get the worm’s width, in centimeters(mm), which will be a floating-point number.
    //You should convert the length in centimeters (multiply it by 100). Then you should divide the length and the width and find the remainder of the division.
    //If it is zero or cannot be calculated, you should print the product of the length and the width (length* width), rounded to the second digit after the decimal point.
    //If the remainder is NOT zero, you should print what percentage is the length of the width.
    //Print it rounded to the second digit after the decimal point. 
    //Example: length = 1cm ; width = 30mm.percentage = 333.33 %. 

    public class WormTest
    {
        public static void Main()
        {

            var wormLength = int.Parse(Console.ReadLine()) * 100;
            var wormWidth = decimal.Parse(Console.ReadLine());
            var ratio = 0m;
            if (wormWidth == 0)
            {
                Console.WriteLine((wormLength * wormWidth).ToString("f2"));
            }
            else
            {
                var remainder = wormLength % wormWidth;
                if (remainder == 0)
                {
                    Console.WriteLine((wormLength * wormWidth).ToString("f2"));
                }
                else
                {
                    ratio = wormLength / wormWidth * 100;
                    Console.WriteLine(ratio.ToString("f2") + '%');
                }
            }
        }
    }
}