using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    interface IState
    {
        // 按下滑鼠
        void PressPointer(double X, double Y, string type, IShape shape);

        //移動滑鼠
        IShape MovePointer(double X, double Y);

        // 放開滑鼠
        IShape ReleasePointer(double firstPointX, double firstPointY, double X, double Y, string type);
    }
}
