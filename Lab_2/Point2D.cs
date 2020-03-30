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
        private double xShift = 0;
        private double yShift = 0;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()
        {
            return x + xShift;
        }

        public double GetY()
        {
            return y + yShift;
        }

        #region КОСТЫЛИ
        public double GetShiftX()
        {
            return xShift;
        }
        public double GetShiftY()
        {
            return yShift;
        }
        #endregion НЕ ТРОГАТЬ

        public void ShiftX(double value)
        {
            xShift = value;
        }

        public void ShiftY(double value)
        {
            yShift = value;
        }

        public double GetDistance(Point2D otherPoint)
        {
            return Math.Sqrt(Math.Pow(x - otherPoint.x, 2) + Math.Pow(y - otherPoint.y, 2));
        }
    }
}
