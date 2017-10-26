using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Equation
    {
        private double a, b, c, desc;

        public Equation(double alfa, double b, double c)
        {
            this.a = alfa;
            this.b = b;
            this.c = c;
            this.desc = this.GetDesc();
        }

        public double GetDesc()
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }

        public String toString()
        {
            return $"\n {a}x^2 + {b}x + {c} = 0 \n";
        }

        public string getRoots()
        {
            if (desc > 0)
                return $"x1 = {(-1 * b + Math.Sqrt(desc)) / 2 * a}, x2 = {(-1 * b - Math.Sqrt(desc)) / 2 * a}.";
            else if (desc == 0)
                return $"x1 = {(-1 * b) / 2 * a}, x2 = not a root.";
            else
                return "there is no roots ";
        }
    }
}
