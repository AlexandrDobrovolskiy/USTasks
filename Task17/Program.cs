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

            List<Section> sections = new List<Section>();

            for (int i = 0; i < points.Count - 1 ; i++)
                sections.Add(new Section(points[i], points[i + 1]));

            Section last = sections[sections.Count - 1];

            bool isPoligon = !(Section.Rotate(sections[0].A, sections[0].B, last.B) == 0);

            for (int i = 1; i < sections.Count; i++)
            {
                if (!isPoligon)
                    break;

                for (int j = 0; j < i; j++)
                {
                    if (Section.Intersect(sections[i], sections[j]))
                    {
                        isPoligon = false;
                        break;
                    }
                }
            }

            WriteLine(isPoligon);
           
            ReadKey();

        }
    }
}
