using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;

namespace Lab_2
{
    class DrawClass
    {
        public static Random rnd = new Random();

        const int s = 100;

        public static Point2D RandomPoint()
        {
            const int MAX = 300;
            
            // вставить пределы генерации, по размеру label
            double x = rnd.NextDouble() * MAX;
            double y = rnd.NextDouble() * MAX;

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
            Point2D point2 = new Point2D(point1.GetX() + rnd.NextDouble() * s, point1.GetY());
            Point2D point3 = new Point2D(point2.GetX(), point1.GetY() + rnd.NextDouble() * s);
            Point2D point4 = new Point2D(point1.GetX(), point3.GetY());

            Rectangle rndRectangle = new Rectangle(point1, point2, point3, point4);

            return rndRectangle;
        }

        public static Rectangle Square()
        {
            // нумерация точек от левой верхней, по часовой стрелке
            Point2D point1 = RandomPoint();
            Point2D point2 = new Point2D(point1.GetX() + rnd.NextDouble() * s, point1.GetY());
            Point2D point3 = new Point2D(point2.GetX(), point2.GetY() + point2.GetDistance(point1));
            Point2D point4 = new Point2D(point1.GetX(), point3.GetY());

            Rectangle rndRectangle = new Rectangle(point1, point2, point3, point4);

            return rndRectangle;
        }
    }
}
