using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using DrawingModel;

namespace DrawingApp.PresentationModel
{
    class PresentationModel
    {
        Model _model;
        IGraphics _igraphics;
        string _mode = "line";
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();

        public PresentationModel(Canvas canvas)
        {
            this._model = new Model();
            _igraphics = new WindowsAppGraphicsAdaptor(canvas);
        }

        // 畫
        public void Draw()
        {
            // 重複使用igraphics物件
            _model.Draw(_igraphics);
        }

        // 清除
        public void Clear()
        {
            _model.Clear();
        }

        // 滑鼠點下
        public void PointerPressed(double X, double Y)
        {
            _model.PointerPressed(X, Y, _mode);
        }

        // 滑鼠放開
        public void PointerReleased(double X, double Y)
        {
            _model.PointerReleased(X, Y, _mode);
        }

        // 滑鼠移動
        public void PointerMoved(double X, double Y)
        {
            _model.PointerMoved(X, Y);
        }

        // 通知
        void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
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

