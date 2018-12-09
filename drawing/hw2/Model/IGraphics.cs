using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    interface IGraphics
    {
        // 清除全部圖案
        void ClearAll();

        // 畫出線
        void DrawLine(double x1, double y1, double x2, double y2);

        // 畫出菱形
        void DrawDaimond(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4);
    }
}
