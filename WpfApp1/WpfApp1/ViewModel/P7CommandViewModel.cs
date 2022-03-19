using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.ViewModel
{
    public class P7CommandViewModel : ViewModelBase
    {
        // UI 上可绑定的命令字段
        public MyCommand ShowCommand { get; set; }

        public P7CommandViewModel()
        {
            // 给命令绑定执行逻辑回调
            ShowCommand = new MyCommand(Show);
        }

        public void Show()
        {
            Name = "点击了按钮";
            Title = "New Title";
            MessageBox.Show(Name);
        }

        private string name = "张三";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                OnPropertyChanged();
            }
        }

        private string title = "default title";
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        //public event PropertyChangedEventHandler PropertyChanged;
    }
}
