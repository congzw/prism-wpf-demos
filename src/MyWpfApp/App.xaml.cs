using System.Windows;
using MyWpfApp.Views;
using Prism.Ioc;
using Prism.Unity;

namespace MyWpfApp
{
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
