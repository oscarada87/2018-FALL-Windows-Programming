using System.Drawing;
using DrawingModel;
using System;

namespace hw2.PresentationModel
{
    class WindowsFormsGraphicsAdaptor : IGraphics
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
        public void DrawLine(double x1, double y1, double x2, double y2, bool selected)
        {
            //Console.WriteLine(x1);
            //Console.WriteLine(y1);
            Point point1 = new Point((int)x1, (int)y1);
            Point point2 = new Point((int)x2, (int)y2);
            _graphics.DrawLine(selected ? Pens.Red : Pens.Black, point1, point2);
        }

        // 畫菱形
        public void DrawDiamond(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, bool selected)
        {
            //Console.WriteLine("123");
            //Console.WriteLine(x1);
            //Console.WriteLine(y1);
            Point[] points = { new Point((int)x1, (int)y1), new Point((int)x2, (int)y2), new Point((int)x3, (int)y3), new Point((int)x4, (int)y4) };
            _graphics.FillPolygon(Brushes.Yellow, points);
            _graphics.DrawPolygon(selected ? Pens.Red : Pens.Black, points);
        }

        // 畫橢圓
        public void DrawEllipse(double x1, double y1, double width, double height, bool selected)
        {
            _graphics.FillEllipse(Brushes.Yellow, (int)x1, (int)y1, (int)width, (int)height);
            _graphics.DrawEllipse(selected ? Pens.Red : Pens.Black, (int)x1, (int)y1, (int)width, (int)height);
        }
    }
}

