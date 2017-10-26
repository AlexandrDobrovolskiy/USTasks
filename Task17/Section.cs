using System;
using System.Collections.Generic;
using System.Text;

namespace Task17
{
    class Section
    {
        private Point a, b;

        public Point A { get => a; set => a = value; }
        public Point B { get => b; set => b = value; }

        public Section(Point a, Point b)
        {
            this.a = a;
            this.b = b;
        }

        public static int Rotate(Point a, Point b, Point c)
        {
            return (b.x - a.x) * (c.y - b.y) - (b.y - a.y) * (c.x - b.x);
        }

        public static bool Intersect(Section first, Section second)
        {
            Point a = first.a;
            Point b = first.b;
            Point c = second.a;
            Point d = second.b;

            return Rotate(a, b, c) * Rotate(a, b, d) < 0 && Rotate(c, d, a) * Rotate(c, d, b) < 0;
        }
    }
}
