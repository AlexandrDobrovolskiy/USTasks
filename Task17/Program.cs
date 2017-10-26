using System;
using System.Collections.Generic;
using static System.Console;
using static System.Int32;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter points you want (example 0,0 1,2 3,4...) : ");
            String[] inputs = ReadLine().Split();

            List<Point> points = new List<Point>(); 

            foreach (String point in inputs)
            {
                String[] coords = point.Split(',');
                points.Add(new Point(Parse(coords[0]), Parse(coords[1])) );
            }

            bool result = true;

            for (int i = 2; i < points.Count; i++)
            {

            }

            ReadKey();
        }
    }
}
