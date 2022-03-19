using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp4
{
    public class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public Action action;
        public Command(Action act)
        {
            action = act;
        }

        public bool CanExecute(object? parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object? parameter)
        {
            //throw new NotImplementedException();
            action();
        }
    }
}
