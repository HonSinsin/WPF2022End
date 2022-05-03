using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTodo.Common.Models;

namespace WPFTodo.ViewModels
{
    public class MemoViewModel : BindableBase
    {
        public MemoViewModel()
        {
            MemoDtoList = new ObservableCollection<MemoDto>();
            CreateToDoList();
            AddCommand = new DelegateCommand(() => { IsRightDrawerOpen = !IsRightDrawerOpen; });
        }

        public DelegateCommand AddCommand { get; set; }

        private ObservableCollection<MemoDto> memoDtoList;

        public ObservableCollection<MemoDto> MemoDtoList
        {
            get { return memoDtoList; }
            set { memoDtoList = value; RaisePropertyChanged(); }
        }

        void CreateToDoList()
        {
            for (int i = 0; i < 20; i++)
            {
                memoDtoList.Add(new MemoDto() { Title = $"Memo {i}", Content = $"Memo Content {i}" });
            }
        }

        private bool isRightDrawerOpen = false;

        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { isRightDrawerOpen = value; RaisePropertyChanged(); }
        }
    }
}
