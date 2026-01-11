using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using WPFTreeView.ViewModel.ViewModels;

namespace WPFTreeView
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindowViewModel vm = new MainWindowViewModel();
            MainWindow view = new MainWindow();
            view.DataContext = vm;
            view.Show();


        }
    }
}
