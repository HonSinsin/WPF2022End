﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFToDo.Shared.Dtos
{
    internal class ToDoDto : BaseDto
    {
        public string Title { get; set; }

        public string Context { get; set; }
    }
}
