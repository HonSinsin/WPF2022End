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
        }

        public ObservableCollection<TaskBar> TaskBarList
        {
            get { return taskBarList; }
            set { taskBarList = value; RaisePropertyChanged(); }
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
