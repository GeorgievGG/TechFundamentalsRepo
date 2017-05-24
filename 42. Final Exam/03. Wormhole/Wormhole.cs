using System;
using System.Linq;

namespace _03.Wormhole
{
    //You will be given a sequence of integers – the wormholes, on a single input line, separated by a space.The integers will either be zeros(0) or some other integers.
    //You must start from the first one and reach the last one.
    //If the integer you are currently at is a zero, you must continue forward to the next element of the sequence. 
    //If the integer you are currently at is NOT zero, it is a wormhole. You must go to the element which is at index – the wormhole’s value.
    //Every time you step on a wormhole, you must set its value to 0.
    //Your task is to calculate exactly how many steps it would take you to reach the end of the sequence.
    //The wormhole’s teleportation to the target index does NOT count as a step.
    //Example: If we have the input “0 0 0 2 0 0 5” . . . the steps would look like this:

    public class Wormhole
    {
        public static void Main()
        {
            var path = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var steps = 0;
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 0)
                {
                    steps++;
                }
                else
                {
                    var tmp = path[i];
                    path[i] = 0;
                    i = tmp - 1;
                }
            }
            Console.WriteLine(steps);
        }
    }
}
