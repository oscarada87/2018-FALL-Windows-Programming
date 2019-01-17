using System.Windows.Forms;
using DrawingModel;

namespace hw2.PresentationModel
{
    class PresentationModel
    {
        private string _mode = "diamond";
        Model _model;
        public event PresentaionModelChangedEventHandler _presentaionModelChanged;
        public delegate void PresentaionModelChangedEventHandler();

        public PresentationModel(Control canvas)
        {
            this._model = new Model();
            _model._modelChanged += HandleModelChanged;
        }

        // 畫
        public void Draw(System.Drawing.Graphics graphics)
        {
            _model.Draw(new WindowsFormsGraphicsAdaptor(graphics));
        }

        // 清除
        public void Clear()
        {
            _model.Clear();
        }

        // 滑鼠按下
        public void PressPointer(int X, int Y)
        {
            _model.PressPointer(X, Y, _mode);
        }

        // 滑鼠放開
        public void ReleasePointer(int X, int Y)
        {
            _model.ReleasePointer(X, Y, _mode);
        }

        // 滑鼠移動
        public void MovePointer(int X, int Y)
        {
            _model.MovePointer(X, Y);
        }

        // 通知
        void NotifyModelChanged()
        {
            if (_presentaionModelChanged != null)
                _presentaionModelChanged();
        }

        // Undo 
        public void Undo()
        {
            _model.Undo();
        }

        // Redo
        public void Redo()
        {
            _model.Redo();
        }

        // 畫面更動
        public void HandleModelChanged()
        {
            NotifyModelChanged();
        }

        public bool ButtonUndoEnabled
        {
            get
            {
                return _model.IsUndoEnable();
            }
        }

        public bool ButtonRedoEnabled
        {
            get
            {
                return _model.IsRedoEnable();
            }
        }

        public string Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
            }
        }
    }
}
