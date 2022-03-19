using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace WpfApp2
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            ShowCommand = new RelayCommand<string>(Show);
        }

        public RelayCommand<string> ShowCommand { get; set; }

        public void Show(string content)
        {
            Name = "点击了按12钮";
            Title = "更新抬313头";
            //MessageBox.Show(content);
            WeakReferenceMessenger.Default.Send(content,"Token1");
        }

        private string name = "123";
        public string Name { get => name; set { name = value; OnPropertyChanged(); } }

        private string title = "title";
        public string Title { get => title; set { title = value; OnPropertyChanged(); } }

    }
}
