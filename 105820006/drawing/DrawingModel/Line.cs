using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Line : IShape
    {
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;
        private bool _selected;

        // 畫線
        public void Draw(IGraphics graphics)
        {
            graphics.DrawLine(_x1, _y1, _x2, _y2, _selected);
        }

        //檢查點有沒有在線上
        public bool DetectInShape(double X, double Y)
        {
            const double MAX_DISTANCE = 4;
            double x2MinusX1 = X2 - X1;
            double y2MinusY1 = Y2 - Y1;
            double upper = Math.Abs((x2MinusX1 * (Y1 - Y)) - ((X1 - X) * y2MinusY1));
            double lower = Math.Sqrt((x2MinusX1 * x2MinusX1) + (y2MinusY1 * y2MinusY1));
            double distance = upper / lower;
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
