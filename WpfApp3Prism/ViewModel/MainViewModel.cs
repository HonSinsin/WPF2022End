using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3Prism.View;

namespace WpfApp3Prism.ViewModel
{
    public class MainViewModel : BindableBase
    {
        public DelegateCommand<string> OpenCommand { get; private set; }

        public MainViewModel()
        {
            OpenCommand = new DelegateCommand<string>(Open);
        }

        private object body;

        public object Body
        {
            get { return body; }
            set { body = value; RaisePropertyChanged(); }
        }


        private void Open(string obj)
        {
            switch (obj)
            {
                case "ViewA": Body = new ViewA(); break;
                case "ViewB": Body = new ViewB(); break;
                case "ViewC": Body = new ViewC(); break;
                default:
                    break;
            }
        }
    }
}
