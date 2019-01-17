using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Diamond : IShape
    {
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;
        private double _pointX1;
        private double _pointY1;
        private double _pointX2;
        private double _pointY2;
        private double _pointX3;
        private double _pointY3;
        private double _pointX4;
        private double _pointY4;
        private bool _selected;
        const int TWO = 2;

        // 畫菱形
        public void Draw(IGraphics graphics)
        {
            CalculatePoint();
            graphics.DrawDiamond(_pointX1, _pointY1, _pointX2, _pointY2, _pointX3, _pointY3, _pointX4, _pointY4, _selected);
        }

        // 算出左右兩個點
        private void CalculatePoint()
        {
            _pointX1 = Math.Abs((_x1 + _x2) / TWO);
            _pointY1 = Math.Min(_y1, _y2);
            _pointX2 = Math.Min(_x1, _x2);
            _pointY2 = Math.Abs((_y1 + _y2) / TWO);
            _pointX3 = Math.Abs((_x1 + _x2) / TWO);
            _pointY3 = Math.Max(_y1, _y2);
            _pointX4 = Math.Max(_x1, _x2);
            _pointY4 = Math.Abs((_y1 + _y2) / TWO);
        }

        //檢查點有沒有在菱形裡
        public bool DetectInShape(double X, double Y)
        {
            const int TWO = 2;
            const double MAX_DISTANCE = 0.5;
            double width = Math.Abs(X1 - X2);
            double height = Math.Abs(Y1 - Y2);
            double centerX = (X1 + X2) / TWO;
            double centerY = (Y1 + Y2) / TWO;
            double distanceX = Math.Abs(X - centerX);
            double distanceY = Math.Abs(Y - centerY);
            double distance = distanceX / width + distanceY / height;
            return distance <= MAX_DISTANCE;
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
