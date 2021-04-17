﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LinePlaneCore
{
    internal interface IDraw
    {
        void Abort(object sender, MouseButtonEventArgs e);
        void Draw(MouseButtonEventArgs e, System.Windows.Controls.Panel canvas);
        void Set(MouseEventArgs e, System.Windows.Controls.Panel canvas);
    }

    internal interface ISelectable
    {
        void Choise_Mouse_Click(object sender, MouseButtonEventArgs e);
    }

    abstract internal class Shape {

        protected MainWindow _window;
        protected Point Offset;
        protected UIElement dragObject;
        abstract protected Image _shape_image
        {
            get;
            set;
        }

        protected Shape(MainWindow window)
        {
            _window = window;
        }
    }

    internal sealed class Draw_Line :Shape, IDraw,ISelectable
    {

        private Line line;
        private bool First_clic = true;

        override protected Image _shape_image
        {
            get { return null; }
            set { }
        }


        public Draw_Line(MainWindow window) : base(window) {
            line = new Line();
           
        }
       


        public void Abort(object sender, MouseButtonEventArgs e)
        {
            if (line != null)
            {
                _window.canvas.Children.Remove(line);
                line = null;
                First_clic = true;
              
            }
        }

        public void Set(MouseEventArgs e, System.Windows.Controls.Panel canvas)
        {
            Point Cursor = _window.Get_Cursor_Point(e);

            if (line == null) return;

            if (First_clic == false)
            {

                line.X2 = Cursor.X - canvas.Margin.Left;
                line.Y2 = Cursor.Y - canvas.Margin.Top;
               
            }
            else
            {
                int rounding_value = (int)Math.Sqrt(Math.Pow(line.X2 - line.X1, 2) + Math.Pow(line.Y2 - line.Y1, 2)) / 5;

                if (rounding_value > 50)
                {
                    rounding_value = 50;
                }

                if (rounding_value < 4)
                {
                    rounding_value = 4;
                }


                if (line.X2 - line.X1 < rounding_value && line.X2 - line.X1 > -rounding_value)
                {
                    line.X2 = line.X1;
                }
                if (line.Y2 - line.Y1 < rounding_value && line.Y2 - line.Y1 > -rounding_value)
                {
                    line.Y2 = line.Y1;
                }

                line = null;

            }
        }

        public void Draw(MouseButtonEventArgs e, System.Windows.Controls.Panel canvas)
        {
            Point Cursor = _window.Get_Cursor_Point(e);

            if (First_clic)
            {
                line = new Line()
                {
                    X1 = (line == null) ? Cursor.X - canvas.Margin.Left : line.X2,
                    Y1 = (line == null) ? Cursor.Y - canvas.Margin.Top : line.Y2,
                    X2 = Cursor.X - canvas.Margin.Left,
                    Y2 = Cursor.Y - canvas.Margin.Top
                };
                line.MouseRightButtonDown += Choise_Mouse_Click;


                line.Stroke = new SolidColorBrush(Colors.Black);

                line.StrokeThickness = 10;

                canvas.Children.Add(line);
            }

            First_clic = !First_clic;
        }


         public void Choise_Mouse_Click(object sender, MouseButtonEventArgs e)
        {
            dragObject = sender as UIElement;
            Offset = e.GetPosition(_window.canvas);
            Offset.X -= Canvas.GetTop(dragObject);
            Offset.Y -= Canvas.GetLeft(dragObject);
            _window.canvas.CaptureMouse();



            ((Line)dragObject).Stroke = new SolidColorBrush(Colors.Gray);
            ((Line)dragObject).StrokeThickness = 6;
            ((Line)dragObject).StrokeDashCap = PenLineCap.Round;
            ((Line)dragObject).StrokeDashArray.Add(2);
        }


    }

    internal sealed class Draw_Cursor : Shape, IDraw,ISelectable
    {
        override protected Image _shape_image
        {
            get { return null; }
            set { }
        }
        public Draw_Cursor(MainWindow window): base (window) { }

        public void Abort(object sender, MouseButtonEventArgs e) { }
        public void Set(MouseEventArgs e, System.Windows.Controls.Panel canvas) { }
        public void Draw(MouseButtonEventArgs e, System.Windows.Controls.Panel canvas) { }

        public void Choise_Mouse_Click(object sender, MouseButtonEventArgs e) { }
    }

    internal class Draw_Square:Shape, IDraw, ISelectable
    {

        private Rectangle shape;
        override protected Image _shape_image
        {
            get;
            set;
        }

        public Draw_Square(MainWindow window, double widith, double height): base (window) {

            shape = new Rectangle();

            shape.MouseRightButtonDown += Choise_Mouse_Click;


            shape.Height = height;
            shape.Width = widith;
            var brash = new BrushConverter();
            shape.Fill = (Brush)brash.ConvertFrom("#CC000000");

            window.canvas.Children.Add(shape);
        }

        public Draw_Square(MainWindow window, double widith, double height,Image _shape_png) : base(window)
        {

            shape = new Rectangle();

            shape.MouseRightButtonDown += Choise_Mouse_Click;

            _shape_image = _shape_png;

            shape.Height = height;
            shape.Width = widith;
            var brash = new BrushConverter();
            shape.Fill = (Brush)brash.ConvertFrom("#CC000000");

            window.canvas.Children.Add(shape);
        }

        public void Abort(object sender, MouseButtonEventArgs e)
        {
            _window.canvas.Children.Remove(shape);
            shape = null;
        }
        public void Set(MouseEventArgs e, System.Windows.Controls.Panel canvas) {

            Point Cursor = _window.Get_Cursor_Point(e);


            if (shape == null) return;

            Canvas.SetLeft (shape, Cursor.X - canvas.Margin.Left - shape.Width/2);
            Canvas.SetTop (shape, Cursor.Y - canvas.Margin.Top - shape.Height / 2);

        }
        public void Draw(MouseButtonEventArgs e, System.Windows.Controls.Panel canvas) {

            if (shape != null)

            shape.Fill = new SolidColorBrush(Colors.Black);

            shape = null;
        }

        public void Choise_Mouse_Click(object sender, MouseButtonEventArgs e)
        {
            dragObject = sender as UIElement;
            Offset = e.GetPosition(_window.canvas);
            Offset.X -= Canvas.GetTop(dragObject);
            Offset.Y -= Canvas.GetLeft(dragObject);
            _window.canvas.CaptureMouse();



            ((Rectangle)dragObject).Stroke = new SolidColorBrush(Colors.Gray);
            ((Rectangle)dragObject).StrokeThickness = 6;
            ((Rectangle)dragObject).StrokeDashCap = PenLineCap.Round;
            ((Rectangle)dragObject).StrokeDashArray.Add(2);
        }
    }

    
}