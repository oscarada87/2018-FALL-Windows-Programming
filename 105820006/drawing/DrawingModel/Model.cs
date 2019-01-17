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
        CommandManager _commandManager;
        List<IShape> _shapes;
        private ShapeFactory _shapeFactory;
        IShape _hint;
        IState _state;

        public Model()
        {
            _shapes = new List<IShape>();
            _commandManager = new CommandManager();
            _shapeFactory = new ShapeFactory();
        }

        // 滑鼠點下
        public void PressPointer(double X, double Y, string type)
        {
            if (X > 0 && Y > 0)
            {
                _firstPointX = X;
                _firstPointY = Y;
                IShape shape = DetectMouseLocation(X, Y);
                if (shape == null)
                {
                    _state = new DrawingState();
                    _state.PressPointer(X, Y, type, shape);
                }
                else
                {
                    _state = new PointerState();
                    _state.PressPointer(X, Y, type, shape);
                    //List<IShape> shapes = new List<IShape>();
                    //shapes.Add(_shapes.Last());
                    //_shapes.Remove(_shapes.Last());
                    //_commandManager.Execute(new MoveCommand(this, shapes));
                }
                _isPressed = true;
            }      
        }

        //檢查滑鼠位置是否有圖型
        private IShape DetectMouseLocation(double X, double Y)
        {
            foreach (IShape shape in _shapes)
            {
                if (shape.DetectInShape(X, Y))
                    return shape;
            }
            return null;
        }

        // 滑鼠移動
        public void MovePointer(double X, double Y)
        {
            if (_isPressed)
            {
                _hint = _state.MovePointer(X, Y);
                NotifyModelChanged();
            }
        }

        // 滑鼠放開
        public void ReleasePointer(double X, double Y, string type)
        {
            //IShape shape;
            if (_isPressed)
            {
                _hint = _state.ReleasePointer(_firstPointX, _firstPointY, X, Y, type);
                _isPressed = false;
                List<IShape> shapes = new List<IShape>();
                shapes.Add(_hint);
                _hint = null;
                _commandManager.Execute(new DrawCommand(this, shapes));
                NotifyModelChanged();
            }
        }

        // 加入一個圖型
        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
            NotifyModelChanged();
        }

        // 移除一個圖型
        public void DeleteShape(IShape shape)
        {
            _shapes.Remove(shape);
            NotifyModelChanged();
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

        // 回復上一步
        public void Undo()
        {
            _commandManager.Undo();
        }

        // 重做上一步
        public void Redo()
        {
            _commandManager.Redo();
        }

        // Redo 可以按嗎?
        public bool IsRedoEnable()
        {
            return _commandManager.RedoEnabled;
        }

        // Undo 可以按嗎?
        public bool IsUndoEnable()
        {
            return _commandManager.UndoEnabled;
        }

        // 通知
        void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }
    }
}
