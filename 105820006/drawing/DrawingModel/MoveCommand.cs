using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class MoveCommand : ICommand
    {
        private Model _model;
        private List<IShape> _shapes;

        public MoveCommand(Model m, List<IShape> shapes)
        {
            _model = m;
            _shapes = shapes;
        }

        //執行
        public void Execute()
        {
            foreach (IShape shape in _shapes)
            {
                _model.DeleteShape(shape);
            }
        }

        // 退回上一步
        public void UnExecute()
        {
            foreach (IShape shape in _shapes)
            {
                _model.AddShape(shape);
            }
        }
    }
}
