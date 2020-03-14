using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2
{
    class DrawClass
    {
        public static Point2D RandomPoint()
        {
            Random rnd = new Random();

            // вставить пределы генерации, по размеру label
            double x = rnd.NextDouble();
            double y = rnd.NextDouble();

            Point2D rndPoint = new Point2D(x, y);

            return rndPoint;
        }

        public static Triangle RandomTriangle()
        {
            Point2D point1 = RandomPoint();
            Point2D point2 = RandomPoint();
            Point2D point3 = RandomPoint();

            Triangle rndTriangle = new Triangle(point1, point2, point3);

            return rndTriangle;
        }

        public static Rectangle RandomRectangle()
        {
            // нумерация точек от левой верхней, по часовой стрелке
            Point2D point1 = RandomPoint();
            Point2D point3 = RandomPoint();
            Point2D point2 = new Point2D(point3.GetX(), point1.GetY());
            Point2D point4 = new Point2D(point1.GetX(), point3.GetY());

            Rectangle rndRectangle = new Rectangle(point1, point2, point3, point4);

            return rndRectangle;
        }

        public static Rectangle FixedRectangle(double x, double y)
        {
            // нумерация точек от левой верхней, по часовой стрелке
            Point2D point1 = new Point2D(x, y);
            Point2D point2 = new Point2D(x, y * 2);
            Point2D point3 = new Point2D(x * 2, y * 2);
            Point2D point4 = new Point2D(x * 2, y);

            Rectangle rndRectangle = new Rectangle(point1, point2, point3, point4);

            return rndRectangle;
        }
    }
}
