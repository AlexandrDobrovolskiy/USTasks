using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    struct Point
    {
        int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
