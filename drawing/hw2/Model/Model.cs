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
        public void PointerPressed(double x, double y, string type)
        {
            _hint = _shapeFactory.CreateShape(type);
            if (x > 0 && y > 0)
            {
                _firstPointX = x;
                _firstPointY = y;
                _hint.X1 = _firstPointX;
                _hint.Y1 = _firstPointY;
                _isPressed = true;
            }       
        }

        // 滑鼠移動
        public void PointerMoved(double x, double y)
        {
            if (_isPressed)
            {
                _hint.X2 = x;
                _hint.Y2 = y;
                NotifyModelChanged();
            }
        }

        // 滑鼠放開
        public void PointerReleased(double x, double y, string type)
        {
            IShape shape;
            if (_isPressed)
            {
                _isPressed = false;
                shape = _shapeFactory.CreateShape(type);
                shape.X1 = _firstPointX;
                shape.Y1 = _firstPointY;
                shape.X2 = x;
                shape.Y2 = y;
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
