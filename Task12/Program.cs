using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 points please: ");
            
            Point[] points = new Point[10];
            String[] input;

            for (int i = 0; i < 10; i++)
            {
                input = Console.ReadLine().Split();
                points.SetValue(new Point(int.Parse(input[0]), int.Parse(input[1])), i);
            }


            double[] distanses = new double[100];

            for(int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    distanses.SetValue(points[i].getDistance(points[j]),(i * 10) + j);
                }
            }

            Array.Sort(distanses);

            Console.WriteLine($"The biggest perimeter is {distanses[99] + distanses[98] + distanses[97]}");

            Console.ReadKey();
        }
    }
}
