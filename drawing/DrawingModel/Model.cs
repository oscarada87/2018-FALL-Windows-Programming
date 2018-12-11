using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        private double _firstPointX;
        private double _firstPointY;
        private bool _isPressed = false;
        List<IShape> _shapes = new List<IShape>();
        private ShapeFactory _shapeFactory = new ShapeFactory();
        IShape _hint;

        // 滑鼠點下
        public void PressPointer(double X, double Y, string type)
        {
            _hint = _shapeFactory.CreateShape(type);
            if (X > 0 && Y > 0)
            {
                _firstPointX = X;
                _firstPointY = Y;
                _hint.X1 = _firstPointX;
                _hint.Y1 = _firstPointY;
                _isPressed = true;
            }       
        }

        // 滑鼠移動
        public void MovePointer(double X, double Y)
        {
            if (_isPressed)
            {
                _hint.X2 = X;
                _hint.Y2 = Y;
                NotifyModelChanged();
            }
        }

        // 滑鼠放開
        public void ReleasePointer(double X, double Y, string type)
        {
            IShape shape;
            if (_isPressed)
            {
                _isPressed = false;
                shape = _shapeFactory.CreateShape(type);
                shape.X1 = _firstPointX;
                shape.Y1 = _firstPointY;
                shape.X2 = X;
                shape.Y2 = Y;
                _shapes.Add(_hint);
                NotifyModelChanged();
            }
        }

        // 清除
        public void Clear()
        {
            _isPressed = false;
            _shapes.Clear();
            NotifyModelChanged();
        }

        // 畫圖
        public void Draw(IGraphics graphics)
        {
            graphics.ClearAll();
            foreach (IShape shape in _shapes)
                shape.Draw(graphics);
            if (_isPressed)
                _hint.Draw(graphics);
        }

        // 通知
        void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }
    }
}
