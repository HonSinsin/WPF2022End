using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp4
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            //ShowCommand = new RelayCommand(Show);
            ShowCommand = new RelayCommand<string>(Show);
        }

        //public RelayCommand ShowCommand { get; set; }
        public RelayCommand<string> ShowCommand { get; set; }

        public void Show(string content)
        {
            Name = "点击了按钮";
            Title = "更新抬头";
            //MessageBox.Show(content);

            Messenger.Default.Send(content, "ShowMBox");
        }

        private string name = "123";
        public string Name { get => name; set { name = value; RaisePropertyChanged(); } }

        private string title = "title";
        public string Title { get => title; set { title = value; RaisePropertyChanged(); } }

    }
}
