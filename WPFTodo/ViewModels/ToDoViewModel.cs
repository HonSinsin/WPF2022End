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
    public class ToDoViewModel : BindableBase
    {
        public ToDoViewModel()
        {
            toDoDtoList = new ObservableCollection<ToDoDto>();
            CreateToDoList();
            AddCommand = new DelegateCommand(() => { IsRightDrawerOpen = !IsRightDrawerOpen; });
        }

        public DelegateCommand AddCommand { get; set; }

        private ObservableCollection<ToDoDto> toDoDtoList;

        public ObservableCollection<ToDoDto> ToDoDtoList
        {
            get { return toDoDtoList; }
            set { toDoDtoList = value; RaisePropertyChanged(); }
        }

        void CreateToDoList()
        {
            for (int i = 0; i < 20; i++)
            {
                toDoDtoList.Add(new ToDoDto() { Title = $"ToDo {i}", Content = $"Content {i}" });
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
