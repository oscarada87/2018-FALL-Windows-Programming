using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
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
        const string DIAMOND = "diamond";
        const string LINE = "line";
        const string ELLIPSE = "ellipse";

        public MainPage()
        {
            this.InitializeComponent();
            _diamond.IsEnabled = false;
            _presentationModel = new PresentationModel.PresentationModel(_canvas);
            _canvas.PointerPressed += HandleCanvasPressed;
            _canvas.PointerReleased += HandleCanvasReleased;
            _canvas.PointerMoved += HandleCanvasMoved;
            _clear.Click += HandleClearButtonClick;
            _diamond.Click += HandleDiamondButtonClick;
            _line.Click += HandleLineButtonClick;
            _ellipse.Click += HandleEllipseButtonClick;
            _presentationModel._presentaionModelChanged += HandleModelChanged;
            _redo.Click += HandleRedoButtonClick;
            _undo.Click += HandleUndoButtonClick;
        }

        // 菱形按鈕按下
        private void HandleDiamondButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.Mode = DIAMOND;
            _diamond.IsEnabled = false;
            _line.IsEnabled = true;
            _ellipse.IsEnabled = true;
        }

        // 線按鈕按下
        private void HandleLineButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.Mode = LINE;
            _diamond.IsEnabled = true;
            _line.IsEnabled = false;
            _ellipse.IsEnabled = true;
        }

        // 橢圓按鈕按下
        private void HandleEllipseButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.Mode = ELLIPSE;
            _diamond.IsEnabled = true;
            _line.IsEnabled = true;
            _ellipse.IsEnabled = false;
        }

        // 清除按鈕按下
        private void HandleClearButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.Clear();
        }

        // Undo 按鈕按下
        public void HandleUndoButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.Undo();
            UpdateRedoUndoButton();
        }

        // Redo 按鈕按下
        public void HandleRedoButtonClick(object sender, RoutedEventArgs e)
        {
            _presentationModel.Redo();
            UpdateRedoUndoButton();
        }

        // 滑鼠按下
        public void HandleCanvasPressed(object sender, PointerRoutedEventArgs e)
        {
            _presentationModel.PressPointer(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        // 滑鼠放開
        public void HandleCanvasReleased(object sender, PointerRoutedEventArgs e)
        {
            _presentationModel.ReleasePointer(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
            UpdateRedoUndoButton();
        }

        // 滑鼠移動
        public void HandleCanvasMoved(object sender, PointerRoutedEventArgs e)
        {
            _presentationModel.MovePointer(e.GetCurrentPoint(_canvas).Position.X, e.GetCurrentPoint(_canvas).Position.Y);
        }

        // 畫面更新
        public void HandleModelChanged()
        {
            _presentationModel.Draw();
        }

        // 更新Redo Undo 按鈕
        private void UpdateRedoUndoButton()
        {
            _redo.IsEnabled = _presentationModel.ButtonRedoEnabled;
            _undo.IsEnabled = _presentationModel.ButtonUndoEnabled;
        }
    }
}
