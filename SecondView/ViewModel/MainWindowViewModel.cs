using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SecondView.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MyCommand MyCommand { get; set; }

        public MainWindowViewModel()
        {
            MyCommand = new MyCommand(Show);
        }

        public void Show()
        {
            Name = "clicked me " + DateTime.Now.ToString();
            MessageBox.Show(Name, "title", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //public string Name { get; set; } = "DEFAULT VALUE";

        private string name = "DEFAULT VALUE";

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }


    }
}
