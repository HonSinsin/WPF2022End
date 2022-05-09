using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFToDo.Shared.Dtos
{
    public class ToDoDto : BaseDto
    {
        private string title;
        private string context;

        public string Title { get => title; set { title = value; OnPropertyChanged(); } }

        public string Context { get => context; set { context = value; OnPropertyChanged(); } }
    }
}
