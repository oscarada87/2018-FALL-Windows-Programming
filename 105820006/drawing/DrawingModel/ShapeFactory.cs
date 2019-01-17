using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class ShapeFactory
    {
        const string DIAMOND = "diamond";
        const string LINE = "line";
        const string ELLIPSE = "ellipse";

        // 創造新的shape
        public IShape CreateShape(string type)
        {
            if (type == LINE)
                return new Line();
            else if (type == DIAMOND)
                return new Diamond();
            else if (type == ELLIPSE)
                return new Ellipse();
            else
                return null;
        }
    }
}
