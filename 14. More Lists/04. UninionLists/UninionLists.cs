using System;
using System.Linq;

namespace _04.UninionLists
{
    class UninionLists
    {
        static void Main()
        {
            var mainList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var incomingLists = int.Parse(Console.ReadLine());
            for (int i = 0; i < incomingLists; i++)
            {
                var newList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for (int j = 0; j < newList.Count; j++)
                {
                    if (!mainList.Contains(newList[j]))
                    {
                        mainList.Add(newList[j]);
                        continue;
                    }
                    for (int k = 0; k < mainList.Count; k++)
                    {
                        if (newList[j] == mainList[k])
                        {
                            mainList.RemoveAt(k);
                        }
                    }
                }
            }
            mainList.Sort();
            Console.WriteLine(/*"remaining: " + */string.Join(" ", mainList));
        }
    }
}
