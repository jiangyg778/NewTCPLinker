using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.SmartParking.Models
{
    public class MenuItemModel
    {
        public string Name { get; set; }  // 菜单名称
        public string IconName { get; set; }  // 图标，可以使用路径或者图片资源
        public string RegionName { get; set; }  // 对应区域名称
        public Type ViewType { get; set; }  // 对应视图类型
    }
}
