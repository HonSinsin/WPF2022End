using Prism.Commands;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModleA.ViewModels
{
    public class ViewCViewModel : IDialogAware
    {
        public string Title { get; set; } = string.Empty;
        public IDialogService DialogService;

        public event Action<IDialogResult> RequestClose;

        public DelegateCommand CancelCommand{get; set;}
        public DelegateCommand SaveCommand { get; set;}

        public ViewCViewModel(IDialogService dialogService) {
            CancelCommand = new DelegateCommand(Cancel);
            SaveCommand = new DelegateCommand(Save);
            DialogService = dialogService;
        }

        public void Save()
        {
            OnDialogClosed();
        }

        public void Cancel()
        {
            DialogParameters keys = new DialogParameters();
            keys.Add("Value", "Return Cancel Value");
            RequestClose?.Invoke(new DialogResult(ButtonResult.No, keys));
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            DialogParameters keys = new DialogParameters();
            keys.Add("Value", "Return Value");
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK, keys));
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
           Title = parameters.GetValue<string>("Title");
        }
    }
}
