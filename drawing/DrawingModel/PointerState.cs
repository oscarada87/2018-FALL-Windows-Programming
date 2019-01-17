using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class PointerState : IState
    {
        IShape _hint;
        List<double> _originalPoint = new List<double> ();
        double _firstPointX;
        double _firstPointY;

        // 按下滑鼠
        public void PressPointer(double X, double Y, string type, IShape shape)
        {
            _firstPointX = X;
            _firstPointY = Y;
            _hint = shape;
            _originalPoint.Add(shape.X1);
            _originalPoint.Add(shape.Y1);
            _originalPoint.Add(shape.X2);
            _originalPoint.Add(shape.Y2);
        }

        // 移動滑鼠
        public IShape MovePointer(double X, double Y)
        {
            Calculate(X, Y);
            _hint.Selected = true;
            return _hint;
        }

        // 計算
        private void Calculate(double secondX, double secondY)
        {
            int DisplacementX = (int)(secondX - _firstPointX);
            int DisplacementY = (int)(secondY - _firstPointY);
            _hint.X1 = _originalPoint[0] + DisplacementX;
            _hint.Y1 = _originalPoint[1] + DisplacementY;
            _hint.X2 = _originalPoint[2] + DisplacementX;
            _hint.Y2 = _originalPoint[3] + DisplacementY;
        }

        // 放開滑鼠
        public IShape ReleasePointer(double firstPointX, double firstPointY, double X, double Y, string type)
        {
            Calculate(X, Y);
            _hint.Selected = false;
            return _hint;
        }
    }
}
