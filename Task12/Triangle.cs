using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    class Triangle
    {
        Point a, b, c;

        Section first, second, third;

        double perimeter;

        public double getPerimeter()
        {
            return perimeter;
        }

        internal Point A { get => a; set => a = value; }
        internal Point B { get => b; set => b = value; }
        internal Point C { get => c; set => c = value; }
        internal Section First { get => first; set => first = value; }
        internal Section Second { get => second; set => second = value; }
        internal Section Third { get => third; set => third = value; }

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            first = new Section(a,b);
            second = new Section(b,c);
            third = new Section(c,a);
            perimeter = first.getLength() + second.getLength() + third.getLength();
        }

        
    }
}
