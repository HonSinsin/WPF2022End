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
    public class IndexViewModel : BindableBase
    {
        private ObservableCollection<TaskBar> taskBarList;

        public IndexViewModel()
        {
            taskBarList = new ObservableCollection<TaskBar>();
            CreateTaskBars();
            CreateToDoDto();
            CreateMemoDto();
        }

        public ObservableCollection<TaskBar> TaskBarList
        {
            get { return taskBarList; }
            set { taskBarList = value; RaisePropertyChanged(); }
        }

        ObservableCollection<ToDoDto> toDoDtoList = new();
        public ObservableCollection<ToDoDto> ToDoDtoList
        {
            get { return toDoDtoList; }
            set { toDoDtoList = value; RaisePropertyChanged(); }
        }

        ObservableCollection<MemoDto> memoDtoList = new();
        public ObservableCollection<MemoDto> MemoDtoList
        {
            get { return memoDtoList; }
            set { memoDtoList = value; RaisePropertyChanged(); }
        }

        void CreateToDoDto()
        {
            for (int i = 0; i < 5; i++)
            {
                toDoDtoList.Add(new ToDoDto() { Content = $"待办事项内容{i}", CreateTime = new DateTime(), Id = i, State = 0, Title = $"待办事项标题{i}", UpdateTime = new DateTime() });
            }
        }


        void CreateMemoDto()
        {
            for (int i = 0; i < 5; i++)
            {
                memoDtoList.Add(new MemoDto() { Content = $"备忘录内容{i}", CreateTime = new DateTime(), Id = i, State = 0, Title = $"备忘录标题{i}", UpdateTime = new DateTime() });
            }
        }
        void CreateTaskBars()
        {
            taskBarList.Add(new TaskBar() { Icon = "WebClock", Title = "汇总", Context = "9", Color = "#FF0CA0FF", Target = "", });
            taskBarList.Add(new TaskBar() { Icon = "ClockCheckOutLine", Title = "已完成", Context = "8", Color = "#FF1ECA3A", Target = "", });
            taskBarList.Add(new TaskBar() { Icon = "ChartLineVariant", Title = "完成比例", Context = "89%", Color = "#FF02C6DC", Target = "", });
            taskBarList.Add(new TaskBar() { Icon = "PlaylistStar", Title = "备忘录", Context = "4", Color = "#FFFFA000", Target = "", });

        }
    }
}
