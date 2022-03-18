using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModel
{
    public class MyCommand : ICommand
    {
        // 创建委托接受创建命令时的回调函数
        Action ExecuteAction;
        public event EventHandler CanExecuteChanged;
        public MyCommand(Action action)
        {
            ExecuteAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ExecuteAction();
        }
    }
}
