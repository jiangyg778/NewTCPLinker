using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TCPLinker.Base.Utils;
using TouchSocket.Core;
using TouchSocket.Sockets;

namespace TCPLinker.ViewModels.Pages
{
    class HomeSettingViewModel : BindableBase
    {

        private TcpClient _TcpClient = new TcpClient();
        private TcpService _TcpService = new TcpService();
        private UdpSession _UdpSession = new UdpSession();

        private ObservableCollection<string> _ProtocolTypes = new ObservableCollection<string> { "TCP Clicent", "TCP Server", "UDP" };
        public ObservableCollection<string> ProtocolTypes
        {
            get { return _ProtocolTypes; }
            set { SetProperty(ref _ProtocolTypes, value); }
        }

        //当前选中的协议类型
        private string _SelectedProtocolType = "TCP Clicent";
        public string SelectedProtocolType
        {
            get { return _SelectedProtocolType; }
            set { SetProperty(ref _SelectedProtocolType, value); }
        }
        // id选项
        private ObservableCollection<string> _IPAddress = new ObservableCollection<string>();
        public ObservableCollection<string> IPAddress
        {
            get { return _IPAddress; }
            set { SetProperty(ref _IPAddress, value); }
        }

        //当前选中的ip地址
        private string _SelectedIPAddress = "127.0.0.1";
        public string SelectedIPAddress
        {
            get { return _SelectedIPAddress; }
            set { SetProperty(ref _SelectedIPAddress, value); }
        }

        //当前输入的端口号
        private string _Port = "8080";
        public string Port
        {
            get { return _Port; }
            set { SetProperty(ref _Port, value); }
        }

        //备注
        private string _Remark = "";
        public string Remark
        {
            get { return _Remark; }
            set { SetProperty(ref _Remark, value); }
        }

        // 当前链接状态
        private bool _ConnectState = false;
        public bool ConnectState
        {
            get { return _ConnectState; }
            set { SetProperty(ref _ConnectState, value); }
        }

        // 日志数据
        private string _LogData = "";
        public string LogData
        {
            get { return _LogData; }
            set { 
                SetProperty(ref _LogData, value);
               
            }
        }

        // 消息数据
        private string _messaggeData="";
        public string MessageData
        {
            get { return _messaggeData; }
            set
            {
                SetProperty(ref _messaggeData, value);

            }
        }

        // 发送消息
        private string _sendmessagge = "";
        public string SendmessaggeData
        {
            get { return _sendmessagge; }
            set
            {
                SetProperty(ref _sendmessagge, value);

            }
        }



        public DelegateCommand BeginCommand { get; set; }
        public DelegateCommand SendMessageCommand { get; set; }

        public HomeSettingViewModel()
        {
            GetIps();
            BeginCommand = new DelegateCommand(BeginAction);
            SendMessageCommand = new DelegateCommand(SendMessageAction);
        }

        private void SendMessageAction()
        {
            _TcpClient.Send(Encoding.UTF8.GetBytes(SendmessaggeData));
            MessageData+="发送:" + SendmessaggeData.FormatStringLog();
            //延迟1s
            Task.Delay(1000);
            SendmessaggeData = "";



        }

        private void GetIps()
        {
            IPAddress.Add("127.0.0.1");
            //查找添加当前所有ip
            foreach (var item in System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    IPAddress.Add(item.ToString());
            }
            IPAddress.Add("0.0.0.0");
        }

        private async void BeginAction()
        {
            if (SelectedProtocolType == "TCP Clicent")
            {
                await StartTcpClientAsync();
            }
            else if (SelectedProtocolType == "TCP Server")
            {
                StartTcpServer();
            }
            else if (SelectedProtocolType == "UDP")
            {
                StartUdp();
            }
        }

        private async Task StartTcpClientAsync()
        {
            if (!ConnectState)
            {
                try
                {
                    // 配置和连接
                    await _TcpClient.SetupAsync(new TouchSocketConfig()
                         .SetRemoteIPHost($"{SelectedIPAddress}:{Port}")
                         .ConfigureContainer(a =>
                         {
                             a.AddConsoleLogger();
                         }));

                    await _TcpClient.ConnectAsync(); 
                    _TcpClient.Received = (client, e) =>
                    {
                        //从服务器收到信息
                        string mes = e.ByteBlock.Span.ToString(Encoding.UTF8);
                        MessageData += "接收:" + mes.FormatStringLog();
                        return EasyTask.CompletedTask;
                    };


                    // 更新日志
                    LogData += "客户端成功连接".FormatStringLog();
                    ConnectState = true;
                }
                catch (Exception ex)
                {
                    LogData += $"连接失败：{ex.Message}".FormatStringLog();
                    await DingDingBot.SendMessageAsync(LogData);
                }
            }
            else
            {
                // 断开连接
                await _TcpClient.CloseAsync();
                LogData += "客户端已断开连接".FormatStringLog();
                await DingDingBot.SendMessageAsync(LogData);

                ConnectState = false;
            }
        }
        private void StartTcpServer()
        {
            //提示未完成
            MessageBox.Show("未完成");
        }
        private void StartUdp()
        {
            //提示未完成
            MessageBox.Show("未完成");
        }
    }
}
