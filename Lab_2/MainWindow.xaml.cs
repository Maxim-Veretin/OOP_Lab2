using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triangle tri;
        Rectangle rec;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawLine(Point2D point1, Point2D point2)
        {
            Line line = new Line();

            line.Stroke = Brushes.Black;
            line.StrokeThickness = 5;

            line.X1 = point1.GetX();
            line.X2 = point2.GetX();
            line.Y1 = point1.GetY();
            line.Y2 = point2.GetY();

            canvas.Children.Add(line);
        }

        private void DrawTriangle(Triangle triangle)
        {
            DrawLine(triangle.GetPoint1(), triangle.GetPoint2());
            DrawLine(triangle.GetPoint2(), triangle.GetPoint3());
            DrawLine(triangle.GetPoint3(), triangle.GetPoint1());
        }

        private void DrawRectangle(Rectangle rectangle)
        {
            DrawLine(rectangle.GetPoint1(), rectangle.GetPoint2());
            DrawLine(rectangle.GetPoint2(), rectangle.GetPoint3());
            DrawLine(rectangle.GetPoint3(), rectangle.GetPoint4());
            DrawLine(rectangle.GetPoint4(), rectangle.GetPoint1());
        }

        private void rndTr_Click(object sender, RoutedEventArgs e)
        {
            shiftx.Value = 0;
            shifty.Value = 0;
            canvas.Children.Clear();
            rec = null;

            tri = DrawClass.RandomTriangle();
            
            DrawTriangle(tri);

            info.Content = "point1("     + Math.Round(tri.GetPoint1().GetX()).ToString() + ";" + Math.Round(tri.GetPoint1().GetY()).ToString() + ")\n" +
                           "point2("     + Math.Round(tri.GetPoint2().GetX()).ToString() + ";" + Math.Round(tri.GetPoint2().GetY()).ToString() + ")\n" +
                           "point3("     + Math.Round(tri.GetPoint3().GetX()).ToString() + ";" + Math.Round(tri.GetPoint3().GetY()).ToString() + ")\n" +
                           "Perimeter: " + Math.Round(tri.GetPerimeter()).ToString() + "\n" +
                           "Area: "      + Math.Round(tri.GetArea()).ToString();
        }

        private void rndRect_Click(object sender, RoutedEventArgs e)
        {
            shiftx.Value = 0;
            shifty.Value = 0;
            canvas.Children.Clear();
            tri = null;

            rec = DrawClass.RandomRectangle();

            DrawRectangle(rec);

            info.Content = "point1("     + Math.Round(rec.GetPoint1().GetX()).ToString() + ";" + Math.Round(rec.GetPoint1().GetY()).ToString() + ")\n" +
                           "point2("     + Math.Round(rec.GetPoint2().GetX()).ToString() + ";" + Math.Round(rec.GetPoint2().GetY()).ToString() + ")\n" +
                           "point3("     + Math.Round(rec.GetPoint3().GetX()).ToString() + ";" + Math.Round(rec.GetPoint3().GetY()).ToString() + ")\n" +
                           "point4("     + Math.Round(rec.GetPoint4().GetX()).ToString() + ";" + Math.Round(rec.GetPoint4().GetY()).ToString() + ")\n" +
                           "Perimeter: " + Math.Round(rec.GetPerimeter()).ToString() + "\n" +
                           "Area: "      + Math.Round(rec.GetArea()).ToString();
        }

        private void square_Click(object sender, RoutedEventArgs e)
        {
            shiftx.Value = 0;
            shifty.Value = 0;
            canvas.Children.Clear();
            tri = null;

            rec = DrawClass.Square();

            DrawRectangle(rec);

            info.Content = "point1(" + Math.Round(rec.GetPoint1().GetX()).ToString() + ";" + Math.Round(rec.GetPoint1().GetY()).ToString() + ")\n" +
                           "point2(" + Math.Round(rec.GetPoint2().GetX()).ToString() + ";" + Math.Round(rec.GetPoint2().GetY()).ToString() + ")\n" +
                           "point3(" + Math.Round(rec.GetPoint3().GetX()).ToString() + ";" + Math.Round(rec.GetPoint3().GetY()).ToString() + ")\n" +
                           "point4(" + Math.Round(rec.GetPoint4().GetX()).ToString() + ";" + Math.Round(rec.GetPoint4().GetY()).ToString() + ")\n" +
                           "Perimeter: " + Math.Round(rec.GetPerimeter()).ToString() + "\n" +
                           "Area: " + Math.Round(rec.GetArea()).ToString();
        }

        private void shiftx_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double moveX = shiftx.Value;

            if (tri != null)
            {
                if (((tri.GetPoint1().GetX() < 600) && (tri.GetPoint2().GetX() < 600) && (tri.GetPoint3().GetX() < 600) && (moveX > tri.GetPoint1().GetShiftX()) && (moveX > tri.GetPoint2().GetShiftX()) && (moveX > tri.GetPoint3().GetShiftX())) ||
                    ((tri.GetPoint1().GetX() > 0) && (tri.GetPoint2().GetX() > 0) && (tri.GetPoint3().GetX() > 0) && (moveX < tri.GetPoint1().GetShiftX()) && (moveX < tri.GetPoint2().GetShiftX()) && (moveX < tri.GetPoint3().GetShiftX())))
                {
                    TriangleMoveHorizontal();
                }
                else { }
            }
            else
            {
                if (((rec.GetPoint3().GetX() < 600) && (moveX > rec.GetPoint3().GetShiftX())) ||
                    ((rec.GetPoint1().GetX() > 0) && (moveX < rec.GetPoint1().GetShiftX())))
                {
                    RectangleMoveHorizontal();
                }
                else { }
            }
        }

        private void shifty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double moveY = shifty.Value;

            if (tri != null)
            {
                if (((tri.GetPoint1().GetY() < 300) && (tri.GetPoint2().GetY() < 300) && (tri.GetPoint3().GetY() < 300) && (moveY > tri.GetPoint1().GetShiftY()) && (moveY > tri.GetPoint2().GetShiftY()) && (moveY > tri.GetPoint3().GetShiftY())) ||
                    ((tri.GetPoint1().GetY() > 0) && (tri.GetPoint2().GetY() > 0) && (tri.GetPoint3().GetY() > 0) && (moveY < tri.GetPoint1().GetShiftY()) && (moveY < tri.GetPoint2().GetShiftY()) && (moveY < tri.GetPoint3().GetShiftY())))
                {
                    TriangleMoveVertical();
                }
                else { }
            }
            else
            {
                if (((rec.GetPoint3().GetY() < 300) && (moveY > rec.GetPoint3().GetShiftY())) ||
                    ((rec.GetPoint1().GetY() > 0) && (moveY < rec.GetPoint3().GetShiftY())))
                {
                    RectangleMoveVertical();
                }
                else { }
            }
        }

        //private void shiftx_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    double moveX = shiftx.Value;

        //    if (tri != null)
        //    {
        //        if ((tri.GetPoint1().GetX() < 600) && (tri.GetPoint2().GetX() < 600) && (tri.GetPoint3().GetX() < 600) && (moveX > tri.GetPoint1().GetShiftX()) && (moveX > tri.GetPoint2().GetShiftX()) &&
        //                                                                                                                                                            (moveX > tri.GetPoint3().GetShiftX()))
        //        {
        //            RightTriangleMove();
        //        }
        //        else if ((tri.GetPoint1().GetX() > 0) && (tri.GetPoint2().GetX() > 0) && (tri.GetPoint3().GetX() > 0) && (moveX < tri.GetPoint1().GetShiftX()) && (moveX < tri.GetPoint2().GetShiftX()) &&
        //                                                                                                                                                            (moveX < tri.GetPoint3().GetShiftX()))
        //        {
        //            LeftTriangleMove();
        //        }
        //        else { }
        //    }
        //    else//////////////////////////////////
        //    {
        //        if ((rec.GetPoint3().GetX() < 600) && (moveX > rec.GetPoint3().GetShiftX()))
        //        {
        //            RightRectangleMove();
        //        }
        //        else if ((rec.GetPoint1().GetX() > 0) && (moveX < rec.GetPoint1().GetShiftX()))
        //        {
        //            LeftRectangleMove();
        //        }
        //        else { }
        //    }
        //}

        //private void shifty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    double moveY = shifty.Value;

        //    if (tri != null)
        //    {
        //        if ((tri.GetPoint1().GetY() < 300) && (tri.GetPoint2().GetY() < 300) && (tri.GetPoint3().GetY() < 300) && (moveY > tri.GetPoint1().GetShiftX()) && (moveY > tri.GetPoint2().GetShiftX()) &&
        //                                                                                                                                                            (moveY > tri.GetPoint3().GetShiftX()))
        //        {
        //            DownTriangleMove();
        //        }
        //        else if ((tri.GetPoint1().GetY() > 0) && (tri.GetPoint2().GetY() > 0) && (tri.GetPoint3().GetY() > 0) && (moveY < tri.GetPoint1().GetShiftX()) && (moveY < tri.GetPoint2().GetShiftX()) &&
        //                                                                                                                                                            (moveY < tri.GetPoint3().GetShiftX()))
        //        {
        //            UpTriangleMove();
        //        }
        //        else { }
        //    }
        //    else
        //    {
        //        if ((rec.GetPoint3().GetY() < 300) && (moveY > rec.GetPoint3().GetShiftX()))
        //        {
        //            DownRectangleMove();
        //        }
        //        else if ((rec.GetPoint1().GetY() > 0) && (moveY < rec.GetPoint3().GetShiftX()))
        //        {
        //            UpRectangleMove();
        //        }
        //        else { }
        //    }
        //}

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            shiftx.Value = 0;
            shifty.Value = 0;
            canvas.Children.Clear();
        }







        private void TriangleMoveHorizontal()
        {
            tri.GetPoint1().ShiftX(shiftx.Value);
            tri.GetPoint2().ShiftX(shiftx.Value);
            tri.GetPoint3().ShiftX(shiftx.Value);

            canvas.Children.Clear();
            DrawTriangle(tri);
        }

        private void RectangleMoveHorizontal()
        {
            rec.GetPoint1().ShiftX(shiftx.Value);
            rec.GetPoint2().ShiftX(shiftx.Value);
            rec.GetPoint3().ShiftX(shiftx.Value);
            rec.GetPoint4().ShiftX(shiftx.Value);

            canvas.Children.Clear();
            DrawRectangle(rec);
        }

        private void TriangleMoveVertical()
        {
            tri.GetPoint1().ShiftY(shifty.Value);
            tri.GetPoint2().ShiftY(shifty.Value);
            tri.GetPoint3().ShiftY(shifty.Value);

            canvas.Children.Clear();
            DrawTriangle(tri);
        }

        private void RectangleMoveVertical()
        {
            rec.GetPoint1().ShiftY(shifty.Value);
            rec.GetPoint2().ShiftY(shifty.Value);
            rec.GetPoint3().ShiftY(shifty.Value);
            rec.GetPoint4().ShiftY(shifty.Value);

            canvas.Children.Clear();
            DrawRectangle(rec);
        }








        private void RightTriangleMove()
        {
            tri.GetPoint1().ShiftX(1);
            tri.GetPoint2().ShiftX(1);
            tri.GetPoint3().ShiftX(1);

            canvas.Children.Clear();
            DrawTriangle(tri);
        }
        private void LeftTriangleMove()
        {
            tri.GetPoint1().ShiftX(-1);
            tri.GetPoint2().ShiftX(-1);
            tri.GetPoint3().ShiftX(-1);

            canvas.Children.Clear();
            DrawTriangle(tri);
        }
        private void UpTriangleMove()
        {
            tri.GetPoint1().ShiftY(-1);
            tri.GetPoint2().ShiftY(-1);
            tri.GetPoint3().ShiftY(-1);

            canvas.Children.Clear();
            DrawTriangle(tri);
        }
        private void DownTriangleMove()
        {
            tri.GetPoint1().ShiftY(1);
            tri.GetPoint2().ShiftY(1);
            tri.GetPoint3().ShiftY(1);

            canvas.Children.Clear();
            DrawTriangle(tri);
        }
        private void RightRectangleMove()
        {
            rec.GetPoint1().ShiftX(1);
            rec.GetPoint2().ShiftX(1);
            rec.GetPoint3().ShiftX(1);
            rec.GetPoint4().ShiftX(1);

            canvas.Children.Clear();
            DrawRectangle(rec);
        }
        private void LeftRectangleMove()
        {
            rec.GetPoint1().ShiftX(-1);
            rec.GetPoint2().ShiftX(-1);
            rec.GetPoint3().ShiftX(-1);
            rec.GetPoint4().ShiftX(-1);

            canvas.Children.Clear();
            DrawRectangle(rec);
        }
        private void UpRectangleMove()
        {
            rec.GetPoint1().ShiftY(-1);
            rec.GetPoint2().ShiftY(-1);
            rec.GetPoint3().ShiftY(-1);
            rec.GetPoint4().ShiftY(-1);

            canvas.Children.Clear();
            DrawRectangle(rec);
        }
        private void DownRectangleMove()
        {
            rec.GetPoint1().ShiftY(1);
            rec.GetPoint2().ShiftY(1);
            rec.GetPoint3().ShiftY(1);
            rec.GetPoint4().ShiftY(1);

            canvas.Children.Clear();
            DrawRectangle(rec);
        }
    }
}
