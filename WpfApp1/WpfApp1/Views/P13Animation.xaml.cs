using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApp1.Views
{
    /// <summary>
    /// P13Animation.xaml 的交互逻辑
    /// </summary>
    public partial class P13Animation : Window
    {
        public P13Animation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.Duration = TimeSpan.FromSeconds(2);       // 动画持续的时间
            animation.AutoReverse = true;                       // 是否往返执行
            animation.By = -30;                                 // 动画执行的值
            animation.RepeatBehavior = RepeatBehavior.Forever;  // 执行周期

            // 给 btn 控件绑定宽度属性的动画
            btn.BeginAnimation(Button.WidthProperty, animation);
        }
    }
}
