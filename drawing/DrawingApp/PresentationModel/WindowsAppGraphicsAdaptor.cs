using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media;
using Windows.Foundation;
using DrawingModel;

namespace DrawingApp.PresentationModel
{
    class WindowsAppGraphicsAdaptor : IGraphics
    {
        Canvas _canvas;

        public WindowsAppGraphicsAdaptor(Canvas canvas)
        {
            this._canvas = canvas;
        }

        // 清除全部
        public void ClearAll()
        {
            _canvas.Children.Clear();
        }

        // 畫線
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            Windows.UI.Xaml.Shapes.Line line = new Windows.UI.Xaml.Shapes.Line();
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            line.Stroke = new SolidColorBrush(Colors.Black);
            _canvas.Children.Add(line);
        }

        // 畫菱形
        public void DrawDiamond(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            Polygon polygon = new Polygon();
            PointCollection points = new PointCollection();
            points.Add(new Point(x1, y1));
            points.Add(new Point(x2, y2));
            points.Add(new Point(x3, y3));
            points.Add(new Point(x4, y4));
            polygon.Points = points;
            polygon.Margin = new Windows.UI.Xaml.Thickness(25);
            polygon.Fill = new SolidColorBrush(Colors.Yellow);
            polygon.Stroke = new SolidColorBrush(Colors.Black);
            _canvas.Children.Add(polygon);
        }
    }
}
