using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    class Triangle
    {
        private Point A, B, C;
        
        public Point getA() { return A; }
        public Point getB() { return B; }
        public Point getC() { return C; }

        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public double getPerimeter()
        {
            if ((A.getX() / A.getY()) == (B.getX() / B.getY()) && (A.getX() / A.getY()) == (C.getX() / C.getY()))
                return -1;
            else
                return A.getDistance(B) + A.getDistance(C) + B.getDistance(C);
        }

    }
}
