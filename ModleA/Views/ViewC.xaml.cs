using ModleA.Event;
using Prism.Events;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModleA.Views
{
    /// <summary>
    /// ViewC.xaml 的交互逻辑
    /// </summary>
    public partial class ViewC : UserControl
    {
        private readonly IEventAggregator aggregator;

        public ViewC(IEventAggregator aggregator)
        {
            InitializeComponent();
            this.aggregator = aggregator;
            aggregator.GetEvent<MessageEvent>().Subscribe(SubMessage);
        }

        private void SubMessage(string obj)
        {
            MessageBox.Show($"接收到消息: {obj}");
            aggregator.GetEvent<MessageEvent>().Unsubscribe(SubMessage);
        }
    }
}
