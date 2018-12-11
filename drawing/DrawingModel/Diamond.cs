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
        private double _x3;
        private double _y3;
        private double _x4;
        private double _y4;
        const int TWO = 2;

        // 畫菱形
        public void Draw(IGraphics graphics)
        {
            CalculatePoint();
            graphics.DrawDiamond(_x1, _y1, _x3, _y3, _x2, _y2, _x4, _y4);
        }

        // 算出左右兩個點
        private void CalculatePoint()
        {
            double length = (_y2 - _y1) / TWO;
            _x2 = _x1;
            _y3 = (_y1 + _y2) / TWO;
            _y4 = (_y1 + _y2) / TWO;
            _x3 = _x1 - length;
            _x4 = _x1 + length;
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
    }
}
