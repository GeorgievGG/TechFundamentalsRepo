using System;
using System.Linq;

namespace _02.LadyBugs
{
    public class LadyBugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var lbIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var field = new int[fieldSize];
            for (int i = 0; i < lbIndexes.Count(); i++)
            {
                if (lbIndexes[i] < fieldSize && lbIndexes[i] >= 0)
                {
                    field[lbIndexes[i]] = 1;
                }
            }
            var input = Console.ReadLine();
            while (input != "end")
            {
                var movement = input.Split(' ');
                var lbIndex = long.Parse(movement[0]);
                var direction = movement[1];
                var flyDistance = long.Parse(movement[2]);
                var lastPosition = lbIndex;
                if (lbIndex >= field.Length || lbIndex < 0)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (field[lbIndex] != 1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                do
                {
                    field[lbIndex] = 0;
                    if (direction == "left" && flyDistance > 0)
                    {
                        lastPosition -= flyDistance;
                    }
                    else if (direction == "right" && flyDistance > 0)
                    {
                        lastPosition += flyDistance;
                    }
                    if (lastPosition >= field.Length || lastPosition < 0)
                    {
                        break;
                    }
                } while (field[lastPosition] == 1);
                if (lastPosition < field.Length && lastPosition >= 0)
                {
                    field[lastPosition] = 1;
                }
                lastPosition = 0;
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
