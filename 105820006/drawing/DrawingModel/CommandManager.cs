using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingModel
{
    class CommandManager
    {
        private Stack<ICommand> _undoCommands = new Stack<ICommand>();
        private Stack<ICommand> _redoCommands = new Stack<ICommand>();

        //執行
        public void Execute(ICommand command)
        {
            command.Execute();
            _undoCommands.Push(command);
            _redoCommands.Clear();
        }

        // 回到上一步
        public void Undo()
        {
            if (UndoEnabled)
            {
                ICommand command = _undoCommands.Pop();
                _redoCommands.Push(command);
                command.UnExecute();
            }
        }

        // 回到下一步
        public void Redo()
        {
            if (RedoEnabled)
            {
                ICommand command = _redoCommands.Pop();
                _undoCommands.Push(command);
                command.Execute();
            }
        }

        public bool UndoEnabled
        {
            get
            {
                return _undoCommands.Count > 0;
            }
        }

        public bool RedoEnabled
        {
            get
            {
                return _redoCommands.Count > 0;
            }
        }
    }
}
