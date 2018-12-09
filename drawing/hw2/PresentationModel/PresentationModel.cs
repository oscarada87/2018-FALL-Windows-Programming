using System.Windows.Forms;
using DrawingModel;

namespace hw2.PresentationModel
{
    class PresentationModel
    {
        private string _mode = "daimond";
        Model _model;
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();

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
        public void PointerPressed(int X, int Y)
        {
            _model.PointerPressed(X, Y, _mode);
        }

        // 滑鼠放開
        public void PointerReleased(int X, int Y)
        {
            _model.PointerReleased(X, Y, _mode);
        }

        // 滑鼠移動
        public void PointerMoved(int X, int Y)
        {
            _model.PointerMoved(X, Y);
        }

        // 通知
        void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }

        // 畫面更動
        public void HandleModelChanged()
        {
            NotifyModelChanged();
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
