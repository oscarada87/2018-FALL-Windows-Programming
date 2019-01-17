using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Ellipse : IShape
    {
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;
        private double _top;
        private double _left;
        private double _width;
        private double _height;
        private bool _selected;

        // 畫
        public void Draw(IGraphics graphics)
        {
            CalculatePoint();
            graphics.DrawEllipse(_top, _left, _width, _height, _selected);
        }

        // 檢查點是否在橢圓內
        public bool DetectInShape(double X, double Y)
        {
            bool result = false;
            double xRadius = _width / 2;
            double yRadius = _height / 2;
            double centerX = _top + xRadius;
            double centerY = _left + yRadius;
            double normalizedX = X - centerX;
            double normalizedY = Y - centerY;
            double distance = ((double)(normalizedX * normalizedX) / (xRadius * xRadius)) + ((double)(normalizedY * normalizedY) / (yRadius * yRadius));
            result = distance <= 1;
            return result;
        }

        // 計算點
        private void CalculatePoint()
        {
            _width = Math.Abs(_x2 - _x1);
            _height = Math.Abs(_y2 - _y1);
            if (_x1 < _x2)
                _top = _x1;
            else
                _top = _x2;
            if (_y1 < _y2)
                _left = _y1;
            else
                _left = _y2;
        }

        public double X1
        {
            get
            {
                return _x1;
            }
            set
            {
                _x1 = value;
            }
        }

        public double Y1
        {
            get
            {
                return _y1;
            }
            set
            {
                _y1 = value;
            }
        }

        public double X2
        {
            get
            {
                return _x2;
            }
            set
            {
                _x2 = value;
            }
        }

        public double Y2
        {
            get
            {
                return _y2;
            }
            set
            {
                _y2 = value;
            }
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }
    }
}
