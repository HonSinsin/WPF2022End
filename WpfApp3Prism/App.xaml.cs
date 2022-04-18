//using ModuleA;
//using ModuleB;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp3Prism.Views;

namespace WpfApp3Prism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
            //throw new NotImplementedException();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<ViewA>();
            //containerRegistry.RegisterForNavigation<ViewB>();
            //containerRegistry.RegisterForNavigation<ViewC>();
        }

        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{
        //    moduleCatalog.AddModule<ModuleAProfile>();
        //    moduleCatalog.AddModule<ModuleBProfile>();
        //    base.ConfigureModuleCatalog(moduleCatalog);
        //}

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = @".\Modules"};
        }
    }
}
