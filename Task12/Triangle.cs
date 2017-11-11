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

        public double getPerimeter() => perimeter;

        public double countPerimeter() => first.GetLength() + second.GetLength() + third.GetLength();

        internal Point A { get => a;}
        internal Point B { get => b;}
        internal Point C { get => c;}
        internal Section First { get => first;}
        internal Section Second { get => second;}
        internal Section Third { get => third;}

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            first = new Section(a,b);
            second = new Section(b,c);
            third = new Section(c,a);
            perimeter = countPerimeter();
        }

        
    }
}
