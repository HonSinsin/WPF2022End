using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTodo.Common.Models
{
    /// <summary>
    /// 任务栏
    /// </summary>
    public class TaskBar : BindableBase
    {
        private string icon;
        private string title;
        private string context;
        private string color;
        private string target;

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon
        {
            get { return icon; }
            set { icon = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 内容
        /// </summary>
        public string Context
        {
            get { return context; }
            set { context = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 背景颜色
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 触发目标
        /// </summary>
        public string Target
        {
            get { return target; }
            set { target = value; RaisePropertyChanged(); }
        }
    }
}
