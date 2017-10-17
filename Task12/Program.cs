using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0,1);
            Point b = new Point(0, -1);
            Point c = new Point(1, 0);

            Triangle myTriangle = new Triangle(a,b,c);
            Console.WriteLine(myTriangle.getPerimeter());
        }
    }
}
