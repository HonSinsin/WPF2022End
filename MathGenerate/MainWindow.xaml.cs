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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace MathGenerate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel.MainWindowViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();  //选择文件夹 
            if (FolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)//注意，此处一定要手动引入System.Window.Forms空间，否则你如果使用默认的DialogResult会发现没有OK属性
            {
                txt.Text = FolderBrowserDialog.SelectedPath;
            }




            return;

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = txt.Width;
            animation.To = txt.Width + 30;
            animation.Duration = TimeSpan.FromMilliseconds(800);
            animation.AutoReverse = true;
            animation.RepeatBehavior = new RepeatBehavior(5);
            //animation.ApplyAnimationClock(txt,animation)
            txt.BeginAnimation(TextBlock.WidthProperty, animation);
        }



        /*
        if cbbType == "5/10以内连加":
            gen_add()
        elif cbbType == "5/10以内连减":
            gen_sub()
        elif cbbType == "5/10以内加减混合":
            gen_mix()
          
        f.write("\t\t姓名：   时间：  做对：（   ）题\n\n")
        */
    }
}
