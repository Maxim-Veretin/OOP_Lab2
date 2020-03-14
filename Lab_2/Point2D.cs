using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Point2D
    {
        private double x;
        private double y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public void ShiftX(double x)
        {
            this.x += x;
        }

        public void ShiftY(double y)
        {
            this.y += y;
        }

        public double GetDistance(Point2D otherPoint)
        {
            return Math.Sqrt(Math.Pow(x - otherPoint.x, 2) + Math.Pow(y - otherPoint.y, 2));
        }
    }
}
