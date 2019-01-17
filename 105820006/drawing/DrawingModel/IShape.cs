using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    interface IShape
    {
        // 畫
        void Draw(IGraphics graphics);

        //檢查點有沒有在圖型裡
        bool DetectInShape(double X, double Y);

        double X1
        {
            get;
            set;
        }
        double Y1
        {
            get;
            set;
        }
        double X2
        {
            get;
            set;
        }
        double Y2
        {
            get;
            set;
        }
        bool Selected
        {
            get;
            set;
        }
    }
}
