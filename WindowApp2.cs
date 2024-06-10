using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;

namespace Практическая_25
{
    public class WindowApp2
    {

        int _x, _y;
        Brush _fill;
        Rectangle _rect;

        public int X
        { get { return _x; } }

        public int Y
        { get { return _y; } }

        public Brush Fill
        {
            get { return _fill; }
            set { _fill = value; _rect.Fill = _fill; _rect.Stroke = _fill; }
        }
        public Rectangle Figure
        { get { return _rect; } }

        public WindowApp2(int x, int y, int size, int size2, int color)
        {


            _x = x; _y = y;
            _fill = Brushes.White;
            _rect = new Rectangle();
            _rect.Stroke = _fill;
            _rect.Height = size;
            _rect.Width = size2;

            if (color == 0)
            {
                _rect.Fill = Brushes.White;

            }
            else if (color == 1)
            {
                _rect.Fill = Brushes.White;
            }
            else
            {
                _rect.Fill = Brushes.White;
            }

            Canvas.SetLeft(_rect, _x);
            Canvas.SetTop(_rect, _y);
        }

        public void Show()
        {
            _rect.Visibility = Visibility.Visible;
        }

        public void Hide()
        {
            _rect.Visibility = Visibility.Hidden;
        }

        public void MoveXY(int x, int y)
        {
            _x = x; _y = y;

            Canvas.SetLeft(_rect, _x);
            Canvas.SetTop(_rect, _y);
        }

    }
}
