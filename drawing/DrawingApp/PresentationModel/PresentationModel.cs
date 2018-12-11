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
        string _mode = "diamond";

        public event PresentaionModelChangedEventHandler _presentaionModelChanged;
        public delegate void PresentaionModelChangedEventHandler();

        public PresentationModel(Canvas canvas)
        {
            this._model = new Model();
            _igraphics = new WindowsAppGraphicsAdaptor(canvas);
            _model._modelChanged += HandleModelChanged;
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
        public void PressPointer(double X, double Y)
        {
            _model.PressPointer(X, Y, _mode);
        }

        // 滑鼠放開
        public void ReleasePointer(double X, double Y)
        {
            _model.ReleasePointer(X, Y, _mode);
        }

        // 滑鼠移動
        public void MovePointer(double X, double Y)
        {
            _model.MovePointer(X, Y);
        }

        // 通知
        void NotifyModelChanged()
        {
            if (_presentaionModelChanged != null)
                _presentaionModelChanged();
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

