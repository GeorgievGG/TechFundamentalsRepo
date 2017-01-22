using System;

namespace _4.Elevator
{
    class Elevator
    {
        static void Main()
        {
            int peopleCt = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            if (capacity > peopleCt)
            {
                Console.WriteLine(1/*"All the persons fit inside in the elevator.Only one course is needed."*/);
            }
            else if (peopleCt % capacity == 0)
            {
                Console.WriteLine(peopleCt / capacity/*"{0} courses * {1} people", peopleCt / capacity, capacity*/);
            }
            else
            {
                Console.WriteLine(peopleCt/capacity + 1/*"{0} courses * {1} people + 1 course * {2} persons", peopleCt/capacity , capacity, peopleCt%capacity*/);
            }
        }
    }
}
