using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Triangle
    {
        private Point2D point1;
        private Point2D point2;
        private Point2D point3;

        public void Triangle(Point2D point1, Point2D point2, Point2D point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
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

        public void ShiftX(double value)
        {
            point1.ShiftX(point1.GetX()+ value);
            point2.ShiftX(point2.GetX() + value);
            point3.ShiftX(point3.GetX() + value);
        }

        public void ShiftY(double value)
        {
            point1.ShiftY(point1.GetY() + value);
            point2.ShiftY(point2.GetY() + value);
            point3.ShiftY(point3.GetY() + value);
        }

        public double GetPerimeter()
        {
            double a = point1.GetDistance(point2);
            double b = point2.GetDistance(point3);
            double c = point3.GetDistance(point1);

            return a + b + c;
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;

            double a = point1.GetDistance(point2);
            double b = point2.GetDistance(point3);
            double c = point3.GetDistance(point1);

            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}
