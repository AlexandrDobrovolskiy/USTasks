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

            // Парсинг инпута
            String[] inputs = ReadLine().Split(); 

            //Создание списка который хранит заданые точки
            List<Point> points = new List<Point>(); 

            foreach (String point in inputs)
            {
                String[] coords = point.Split(',');
                points.Add(new Point(Parse(coords[0]), Parse(coords[1])) );
            }

            //Создание списка который хранит грани многоугольника
            List<Section> sections = new List<Section>();   

            for (int i = 0; i < points.Count - 1 ; i++)
                sections.Add(new Section(points[i], points[i + 1]));

            Section last = sections[sections.Count - 1];    

            //Проверяем не лежит ли последняя точка на первой грани и не пересекаются ли первая и последняя грань
            bool isPoligon = !(Section.Rotate(sections[0].A, sections[0].B, last.B) == 0);

            //Ищем пересекающиеся грани
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
