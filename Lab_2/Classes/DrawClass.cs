using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab_2;

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

            Point2D rndPoint = new Point2D();

            rndPoint.SetPoint(x, y);

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
            Point2D point2 = RandomPoint();
            Point2D point3 = RandomPoint();
            Point2D point4 = RandomPoint();

            RandomRectangle rndRectangle = new RandomRectangle(point1, point2, point3, point4);

            return rndRectangle;
        }
    }
}
