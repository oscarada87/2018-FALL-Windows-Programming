using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白頁項目範本已記錄在 https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x404

namespace DrawingApp
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        PresentationModel.PresentationModel _presentationModel;

        public MainPage()
        {
            this.InitializeComponent();
            _presentationModel = new PresentationModel.PresentationModel(_canvas);
            _canvas.PointerPressed += HandleCanvasPressed;
            _canvas.PointerReleased += HandleCanvasReleased;
            _canvas.PointerMoved += HandleCanvasMoved;
            _clear.Click += HandleClearButtonClick;
            _diamond.Click += HandleDiamondButtonClick;
            _line.Click += HandleLineButtonClick;
            _presentationModel._modelChanged += HandleModelChanged;
        }

        // 菱形按鈕
        private void HandleDiamondButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.Mode = "diamond";
        }

        // 線按鈕
        private void HandleLineButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.Mode = "line";
        }

        // 清除按鈕
        private void HandleClearButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.Clear();
        }

        // 滑鼠按下
        public void HandleCanvasPressed(object sender, PointerRoutedEventArgs e)
        {
            _presentationModel.PointerPressed(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        // 滑鼠放開
        public void HandleCanvasReleased(object sender, PointerRoutedEventArgs e)
        {
            _presentationModel.PointerReleased(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        // 滑鼠移動
        public void HandleCanvasMoved(object sender, PointerRoutedEventArgs e)
        {
            _presentationModel.PointerMoved(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        // 畫面更新
        public void HandleModelChanged()
        {
            _presentationModel.Draw();
        }
    }
}
