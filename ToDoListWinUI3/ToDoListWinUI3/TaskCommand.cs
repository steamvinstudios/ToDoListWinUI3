using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoListWinUI3
{
    public class TaskCommand : ICommand
    {
        Action action;
        public event EventHandler CanExecuteChanged;
        public TaskCommand(Action act)
        {
            action = act;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
