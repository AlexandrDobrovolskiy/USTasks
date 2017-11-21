using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Task39
{
    class Node
    {
        private int x, y;

        private int value;

        public Node(int value, int x, int y)
        {
            this.value = value;
            this.x = x;
            this.y = y;
        }
        

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Value { get => value; set => this.value = value; }
    }
}
