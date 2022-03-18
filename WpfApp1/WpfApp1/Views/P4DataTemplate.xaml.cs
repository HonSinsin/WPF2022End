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

namespace WpfApp1.Views
{
    /// <summary>
    /// P4DataTemplate.xaml 的交互逻辑
    /// </summary>
    public partial class P4DataTemplate : Window
    {
        public P4DataTemplate()
        {
            InitializeComponent();

            // 即将淘汰的数据绑定方法
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Items.Add(new ListBoxItem()
            //    {
            //        Content = new TextBlock() { Text = i.ToString() }
            //    });
            //    //list.Items.Add(i.ToString());
            //}

            List<Color> colors = new List<Color>();
            colors.Add(new Color() { Code = "red", Name = "红色" });
            colors.Add(new Color() { Code = "blue", Name = "蓝色" });
            colors.Add(new Color() { Code = "black", Name = "黑色" });
            colors.Add(new Color() { Code = "green", Name = "绿色" });
            colors.Add(new Color() { Code = "pink", Name = "粉色" });
            list.ItemsSource = colors;
            grid.ItemsSource = colors;
            ooo.ItemsSource = colors;
        }
    }

    public class Color
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
