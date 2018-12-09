using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTheory
{
    public struct Point : IComparable<Point>
    {

        public double x;
        public double y;


        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }


        public int CompareTo(Point other)
        {
            if (x < other.x)
                return -1;
            else if (x > other.x)
                return +1;
            else if (y < other.y)
                return -1;
            else if (y > other.y)
                return +1;
            else
                return 0;
        }

    }
}
