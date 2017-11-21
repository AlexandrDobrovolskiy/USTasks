using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class BallInTheBox
    {
        private int x, y, maxX, maxY, speedX, speedY;

        public BallInTheBox(int x, int y, int maxX, int maxY, int speed)
        {
            this.x = x;
            this.y = y;
            this.maxX = maxX;
            this.maxY = maxY;
            this.speedX = speed;
            this.speedY = speed;
        }

        public void Move()
        {
            if (x + speedX < maxX && x + speedX > 0)
            {
                x += speedX;
            }
            else
            {
                x -= speedX;
                speedX *= -1;
            }

            if (y + speedX < maxY && y + speedX > 0)
            {
                y += speedY;
            }
            else
            {
                y -= speedY;
                speedY *= -1;
            }
        }

        public override string ToString()
        {
            return $"The ball's flying with speed on oX is {speedX} on oY is {speedY}, and it's coords is {x},{y}.";
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int MaxX { get => maxX; set => maxX = value; }
        public int MaxY { get => maxY; set => maxY = value; }
    }
}
