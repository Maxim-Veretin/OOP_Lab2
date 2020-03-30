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

        public Triangle(Point2D point1, Point2D point2, Point2D point3)
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
            point1.ShiftX(value);
            point2.ShiftX(value);
            point3.ShiftX(value);
        }

        public void ShiftY(double value)
        {
            point1.ShiftY(value);
            point2.ShiftY(value);
            point3.ShiftY(value);
        }

        public double GetPerimeter()
        {
            return  point1.GetDistance(point2) +
                    point2.GetDistance(point3) +
                    point3.GetDistance(point1);
        }

        public double GetArea()
        {
            return Math.Sqrt(GetPerimeter() / 2 *
                            (GetPerimeter() / 2 - point1.GetDistance(point2)) *
                            (GetPerimeter() / 2 - point2.GetDistance(point3)) *
                            (GetPerimeter() / 2 - point3.GetDistance(point1))
                            );
        }
    }
}
