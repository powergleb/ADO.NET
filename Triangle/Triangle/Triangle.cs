using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{

    class Triangle
    {
        Dot a, b, c;
        public Triangle(Dot a1, Dot b1, Dot c1)
        {
            this.a = a1;
            this.b = b1;
            this.c = c1;

        }
        public double Perimeter()
        {
            double res = 0;
            res += Math.Sqrt(Math.Abs((a.X - b.X) * (a.X - b.X) +
                (a.Y - b.Y) * (a.Y - b.Y)));
            res += Math.Sqrt(Math.Abs((b.X - c.X) * (b.X - c.X) +
                (b.Y - c.Y) * (b.Y - c.Y)));
            res += Math.Sqrt(Math.Abs((c.X - a.X) * (c.X - a.X) +
                (c.Y - a.Y) * (c.Y - a.Y)));
            return res;
        }
        public double Area()
        {
            return 0.5 * Math.Abs((b.X - a.X) * (c.Y - a.Y) -
                (c.X - a.X) * (b.Y - a.Y));
        }
        public bool IsValid()
        {
            if (0.5 * Math.Abs((b.X - a.X) * (c.Y - a.Y) -
                (c.X - a.X) * (b.Y - a.Y)) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
