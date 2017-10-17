using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    class Point
    {
        private double x, y;

        public double getX() { return x; }
        public double getY() { return y; }
        
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getDistance(Point enotherPoint)
        {
            return Math.Sqrt( Math.Pow(this.getX() - enotherPoint.getX(), 2) + Math.Pow(this.getY() - enotherPoint.getY(), 2));
        }
    }
}
