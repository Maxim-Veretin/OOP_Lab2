using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Rectangle
    {
        private Point2D point1;
        private Point2D point2;
        private Point2D point3;
        private Point2D point4;

        public Rectangle(Point2D point1, Point2D point2, Point2D point3, Point2D point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
        }

        public Point2D GetPoint1()
        {
            return point1;
        }

        public Point2D GetPoint2()
        {
            return point2;
        }

        public Point2D GetPoint3()
        {
            return point3;
        }

        public Point2D GetPoint4()
        {
            return point4;
        }

        public void ShiftX(double value)
        {
            point1.ShiftX(value);
            point2.ShiftX(value);
            point3.ShiftX(value);
            point4.ShiftX(value);
        }

        public void ShiftY(double value)
        {
            point1.ShiftY(value);
            point2.ShiftY(value);
            point3.ShiftY(value);
            point4.ShiftY(value);
        }

        public double GetPerimeter()
        {
            return  point1.GetDistance(point2) +
                    point2.GetDistance(point3) +
                    point3.GetDistance(point4) +
                    point4.GetDistance(point1);
        }

        public double GetArea()
        {
            return point1.GetDistance(point2) * point2.GetDistance(point3);
        }
    }
}
