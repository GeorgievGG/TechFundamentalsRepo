using System;
using System.Linq;

namespace WineCraft
{
    class WineCraft
    {
        static void Main()
        {
            var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int growthDays = int.Parse(Console.ReadLine());
            while (grapes.Count > growthDays)
            {
                for (int i = 0; i < growthDays; i++)
                {
                    for (int j = 0; j < grapes.Count; j++)
                    {
                        //if (grapes[j] != 0)
                        //{
                        grapes[j]++;
                        //}
                    }
                    for (int j = 1; j < grapes.Count - 1; j++)
                    {

                        if (grapes[j] > grapes[j - 1] && grapes[j] > grapes[j + 1])
                        {
                            grapes[j]--;
                            if (grapes[j - 1] > 0)
                            {
                                grapes[j]++;
                                grapes[j - 1] = Math.Max(grapes[j - 1] - 2, 0);
                            }
                            if (grapes[j + 1] > 0)
                            {
                                grapes[j]++;
                                grapes[j + 1] = Math.Max(grapes[j + 1] - 2, 0);
                            }
                        }
                    }
                    //Console.WriteLine(/*"remaining: " + */string.Join(" ", grapes));
                }
                for (int i = 0; i < grapes.Count; i++)
                {
                    if (grapes[i] <= growthDays)
                    {
                        grapes.RemoveAt(i);
                        i--;
                    }
                }
            }
            Console.WriteLine(/*"remaining: " + */string.Join(" ", grapes));
        }
    }
}