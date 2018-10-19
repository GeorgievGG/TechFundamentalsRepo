using System;

namespace _4.Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            if (capacity > peopleCount)
            {
                Console.WriteLine(1); /*"All the persons fit inside in the elevator.Only one course is needed."*/
            }
            else if (peopleCount % capacity == 0)
            {
                Console.WriteLine(peopleCount / capacity); /*"{0} courses * {1} people", peopleCt / capacity, capacity*/
            }
            else
            {
                Console.WriteLine(peopleCount / capacity + 1); /*"{0} courses * {1} people + 1 course * {2} persons", peopleCt/capacity , capacity, peopleCt%capacity*/
            }
        }
    }
}
