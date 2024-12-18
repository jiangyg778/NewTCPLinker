using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TCPLinker.Views.Pages
{
    /// <summary>
    /// HomeSetting.xaml 的交互逻辑
    /// </summary>
    public partial class HomeSetting : UserControl
    {
        public HomeSetting()
        {
            InitializeComponent();
        }
        private void LogTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // 让滚动条滚动到底部
            LogTextBox.Dispatcher.BeginInvoke(new Action(() =>
     {
         LogTextBox.ScrollToEnd();
     }), System.Windows.Threading.DispatcherPriority.Background);
        }


        private void MessageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // 让滚动条滚动到底部
            MessageTextBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                MessageTextBox.ScrollToEnd();
            }), System.Windows.Threading.DispatcherPriority.Background);
        }
    }
}
