using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    class Section : IEquatable<Section>, IComparable<Section>
    {
        Point a, b;

        double length;

        internal Point A { get => a; set => a = value; }
        internal Point B { get => b; set => b = value; }

        public Section(Point a, Point b)
        {
            this.a = a;
            this.b = b;
            length = Math.Sqrt( Math.Pow(b.X - a.X , 2) + Math.Pow(a.Y - b.Y, 2));
        }


        public double GetLength()
        {
            return length;
        }

        public bool Equals(Section other)
        {
            if (other == null) return false;
            return (this.length.Equals(other.length));
        }

        public int CompareTo(Section other) => Convert.ToInt32(other.GetLength() - GetLength());


    }
}
