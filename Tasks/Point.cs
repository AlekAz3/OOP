using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Point
    {
        private double x;
        private double y;

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double FindDistance(Point point) => Math.Sqrt(Math.Pow(point.X-this.X, 2) + Math.Pow(point.Y - this.Y, 2));
        
    }
}
