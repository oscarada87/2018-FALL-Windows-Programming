using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class DrawingState : IState
    {
        private ShapeFactory _shapeFactory = new ShapeFactory();
        IShape _hint;

        // 滑鼠點下
        public void PressPointer(double X, double Y, string type, IShape shape)
        {
            _hint = _shapeFactory.CreateShape(type);
            if (X > 0 && Y > 0)
            {
                _hint.X1 = X;
                _hint.Y1 = Y;
            }
        }

        // 移動滑鼠
        public IShape MovePointer(double X, double Y)
        {
            _hint.X2 = X;
            _hint.Y2 = Y;
            return _hint;
        }

        // 放開滑鼠
        public IShape ReleasePointer(double firstPointX, double firstPointY, double X, double Y, string type)
        {
            IShape shape;
            shape = _shapeFactory.CreateShape(type);
            shape.X1 = firstPointX;
            shape.Y1 = firstPointY;
            shape.X2 = X;
            shape.Y2 = Y;
            return shape;
        }
    }
}
