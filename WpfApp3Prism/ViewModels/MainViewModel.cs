using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3Prism.Views;

namespace WpfApp3Prism.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IDialogService regionManager;

        public DelegateCommand<string> OpenCommand { get; private set; }

        private string title = string.Empty;
        public string Title { get { return title; } set { title = value; RaisePropertyChanged(); } }

        public MainViewModel(IDialogService regionManager)
        {
            OpenCommand = new DelegateCommand<string>(Open);
            this.regionManager = regionManager;
        }

        private void Open(string obj)
        {
            //NavigationParameters keys = new NavigationParameters();
            //keys.Add("Title", "Hello!");
            //regionManager.Regions["ContentRegion"].RequestNavigate(obj, keys);

            DialogParameters keys = new DialogParameters() { { "Title", "Dialog Title" } };
            regionManager.ShowDialog(obj, keys, callback =>
            {
                if (callback.Result == ButtonResult.OK)
                {
                    Title = "Result OK";
                }
                else if (callback.Result == ButtonResult.No)
                {
                    Title = "Result No";
                }
            });
        }
    }
}
