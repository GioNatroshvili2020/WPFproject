﻿using Autofac;
using Autofac.Core;
using shitAPp.Data;
using shitAPp.Startup;
using shitAPp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace shitAPp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Bootstrapper bootstrapper = new Bootstrapper();
            var container =  bootstrapper.Bootstrap();
            var mainWindow = container.Resolve<MainWindow>();
            MainWindow.Show();
        }
    }
}
