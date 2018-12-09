using System.Drawing;
using DrawingModel;
using System;

namespace hw2.PresentationModel
{
    class WindowsFormsGraphicsAdaptor: IGraphics
    {
        Graphics _graphics;

        public WindowsFormsGraphicsAdaptor(Graphics graphics)
        {
            this._graphics = graphics;
        }

        // OnPaint時會自動清除畫面，因此不需實作
        public void ClearAll()
        {
            
        }

        // 畫線
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            //Console.WriteLine(x1);
            //Console.WriteLine(y1);
            Point point1 = new Point((int)x1, (int)y1);
            Point point2 = new Point((int)x2, (int)y2);
            _graphics.DrawLine(Pens.Black, point1, point2);
        }

        // 畫菱形
        public void DrawDaimond(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            //Console.WriteLine("123");
            //Console.WriteLine(x1);
            //Console.WriteLine(y1);
            Point[] points = { new Point((int)x1, (int)y1), new Point((int)x2, (int)y2), new Point((int)x3, (int)y3), new Point((int)x4, (int)y4) };
            _graphics.FillPolygon(Brushes.Yellow, points);
            _graphics.DrawPolygon(Pens.Black, points);
        }
    }
}

