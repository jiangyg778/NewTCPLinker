using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TCPLinker.Views.Pages;
using Zhaoxi.SmartParking.Models;

namespace TCPLinker.ViewModels
{
    public class MainViewModel
    {
        //菜单
        public ObservableCollection<MenuItemModel> MenuItems { get; } = new ObservableCollection<MenuItemModel>();

        //command
        public DelegateCommand<MenuItemModel> SelectMenuCommand { get; set; }

        IRegionManager _regionManager;

        public MainViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            //初始化菜单
            MenuItems = new ObservableCollection<MenuItemModel>
            {
                new MenuItemModel
                {
                    Name = "首页",
                    IconName = "&#xe616;",
                    RegionName = "MainRegion",
                    ViewType = typeof(HomeSetting)
                },
                new MenuItemModel
                {
                    Name = "数据库",
                    IconName = "&#xe6a9;",
                    RegionName = "MainRegion",
                    ViewType = typeof(HelpCenter)

                },
                new MenuItemModel
                {
                    Name = "日志",
                    IconName = "&#xe60c;",
                    RegionName = "MainRegion",
                    ViewType = typeof(HelpCenter)

                },
                new MenuItemModel
                {
                    Name = "更新",
                    IconName = "&#xe634;",
                    RegionName = "MainRegion",
                    ViewType = typeof(HelpCenter)

                }
            };

            //初始化command
            SelectMenuCommand = new DelegateCommand<MenuItemModel>(GetSelectMenu);
        }

        public void GetSelectMenu(MenuItemModel menuItem)
        {
            // 使用 RegionManager 动态加载视图
            _regionManager.RequestNavigate(menuItem.RegionName, menuItem.ViewType.Name);
        }
    }
}
