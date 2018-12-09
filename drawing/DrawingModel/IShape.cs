﻿using System;
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
    }
}
