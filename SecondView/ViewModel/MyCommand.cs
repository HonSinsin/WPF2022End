using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SecondView.ViewModel
{
    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action action;

        public MyCommand(Action _action)
        {
            this.action = _action;
        }

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            action();
            //throw new NotImplementedException();
        }
    }
}
