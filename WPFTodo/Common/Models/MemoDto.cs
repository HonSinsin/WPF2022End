using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTodo.Common.Models
{
    public class MemoDto : BaseDto
    {
        private string title = string.Empty;
        private string content = string.Empty;
        private int state;

        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public int State
        {
            get { return state; }
            set { state = value; }
        }
    }
}