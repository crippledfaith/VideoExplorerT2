using System.Windows;

namespace VET2.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            BootStrap bootStrap = new BootStrap();
            bootStrap.Load();
            base.OnStartup(e);
        }
    }
}
