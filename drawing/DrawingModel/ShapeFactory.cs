using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class ShapeFactory
    {
        // 創造新的shape
        public IShape CreateShape(string type)
        {
            if (type == "line")
                return new Line();
            else if (type == "diamond")
                return new Diamond();
            else
                return null;
        }
    }
}
