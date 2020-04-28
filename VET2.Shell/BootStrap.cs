using System;
using VET2.Shell.ViewModel;
using VET2.Shell.Window;

namespace VET2.Shell
{
    public class BootStrap
    {
        internal void Load()
        {
            MainWindow mainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel()
            };
            mainWindow.Show();
        }
    }
}
