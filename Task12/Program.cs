using System;
using System.Collections.Generic;
using static System.Console;
using static System.Int32;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter your points you want (example 1,1 2,1 3,2 ...): ");

            string[] inputs = ReadLine().Split();

            List<Point> points = new List<Point>();

            for (int i = 1; i < inputs.Length; i++)
            {
                string[] coords = inputs[i].Split(',');
                points.Add(new Point(Parse(coords[0]), Parse(coords[1])));
            }

            List<Section> sections = new List<Section>();

            for (int i = 1; i < inputs.Length -1 ; i++)
                for (int j = 0; j < inputs.Length- 1; j++)
                    sections.Add(new Section(points[i], points[j]));

            sections.Sort();


            foreach (Section section in sections)
                WriteLine(section.GetLength());
           

            Triangle resTriangle = new Triangle(sections[0].A, sections[0].B, sections[1].B);

            WriteLine($"The largest triangle has next perimeter {resTriangle.getPerimeter()}.");

            ReadKey();
        }
    }
}
