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

        public void Triangle(Point2D point1, Point2D point2, Point2D point3, Point2D point4)
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
            point1.ShiftX(point1.GetX() + value);
            point2.ShiftX(point2.GetX() + value);
            point3.ShiftX(point3.GetX() + value);
            point4.ShiftX(point4.GetX() + value);
        }

        public void ShiftY(double value)
        {
            point1.ShiftY(point1.GetY() + value);
            point2.ShiftY(point2.GetY() + value);
            point3.ShiftY(point3.GetY() + value);
            point4.ShiftY(point4.GetY() + value);
        }

        public double GetPerimeter()
        {
            double a = point1.GetDistance(point2);
            double b = point2.GetDistance(point3);
            double c = point3.GetDistance(point4);
            double d = point4.GetDistance(point1);

            return a + b + c + d;
        }

        public double GetArea()
        {
            double a = point1.GetDistance(point2);
            double b = point2.GetDistance(point3);

            return a * b;
        }
    }
}
