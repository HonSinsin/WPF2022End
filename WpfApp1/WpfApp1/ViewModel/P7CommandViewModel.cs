using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.ViewModel
{
    public class P7CommandViewModel
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
            MessageBox.Show(Name);
        }

        public string Name { get; set; } = "张三";
    }
}
