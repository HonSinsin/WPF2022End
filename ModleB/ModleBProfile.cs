﻿using ModleB.ViewModels;
using ModleB.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModleB
{
    public class ModleBProfile : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // 一般的在代码中设置匹配项, 不在xaml中设置自动匹配
            containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>();
        }
    }
}
