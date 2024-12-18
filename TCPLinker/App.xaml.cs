using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data;
using System.Windows;
using TCPLinker.IService;
using TCPLinker.ORM;
using TCPLinker.Service;
using TCPLinker.Views;

namespace TCPLinker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            // 返回应用的主窗口，例如 MainWindow
            return Container.Resolve<MainView>();

        }
        protected override void InitializeShell(Window shell)
        {
            // 初始化窗体
            base.InitializeShell(shell);

            Container.Resolve<IRegionManager>().RegisterViewWithRegion("MainRegion", "HomeSetting");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // 注册View
            containerRegistry.RegisterForNavigation<Views.Pages.HomeSetting>();
            containerRegistry.RegisterForNavigation<Views.Pages.HelpCenter>();
            //注册数据库上下文
            containerRegistry.RegisterSingleton<DbContext, TCPLinkerDbContext>();
            // 注册接口
            containerRegistry.Register<IIPService, IPService>();
        }
    }
}
