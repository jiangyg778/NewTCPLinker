   M S B A M L   `   `   `  ����D  @TCPLinker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TCPLinker.Base.ConvertersTCPLinker.Base.Converters  5      =#clr-namespace:TCPLinker.Views.PagesTCPLinker.Views.Pages  5      '    !TCPLinker.Views.Pages.HomeSetting   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      5c'clr-namespace:TCPLinker.Base.Converters     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:TCPLinker.Views.Pages     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5      2  ,TCPLinker.Base.Converters.StateNameConverter   StateNameConverter7  1TCPLinker.Base.Converters.InverseBooleanConverter  InverseBooleanConverter��%:   &	        &	        5   
   6     5   
   6$   5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $
��1.1* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $��5q�5       �� Padding$ 5q�5      
�������$��1q�5       �� CornerRadius$ 5��5      ._�5      �  � RowDefinitions 5      �� 5       $��40 �6$   �� 5!      $��40 �6$   �� 5"      $��40 �6$   �� 5#      $��40 �6$   �� 5$      $��40 �6$   �� 5%       5'      �� 5(      $��80 �6'   �� 5)      $��* �6'   .+�5+      �� $��0��5,      $��0��5-      $
��Left=�5.      $��Center=�5/      $��15(�50      $��协议类型 :��51      �� 52      $��1��53      $��0��54      $
��Left=�55      $��Center=�56      $��15(�57      $��
IP地址 :��58      �� 59      $��2��5:      $��0��5;      $
��Left=�5<      $��Center=�5=      $��15(�5>      $��端口 :��5?      �� 5@      $��3��5A      $��0��5B      $
��Left=�5C      $��Center=�5D      $��15(�5E      $��备注 :��5F      �� 5G      $��0��5H      $��1��5I      $	��140��5J      $��30��5K      $��Center=�5L      $��Center=�5M      $��Center=�5N      {�5O      �� *ConnectState+ �� 	Converter# [ ��5P      �� *ProtocolTypes+ �� SelectedItem 5Q      �� *SelectedProtocolType+�� 5R      $��1��5S      $��1��5T      $	��140��5U      $��30��5V      $��Center=�5W      $��Center=�5X      $��Center=�5Y      {�5Z      �� *ConnectState+# [ ��5[      �� *SelectedIPAddress+�� 5\      $��2��5]      $��1��5^      $	��140��5_      $��30��5`      $��Center=�5a      $��Center=�5b      $��Center=�5c      {�5d      �� *ConnectState+# [ ��5e      �� *Port+�� 5f      $��3��5g      $��1��5h      $	��140��5i      $��30��5j      $��Center=�5k      $��Center=�5l      $��Center=�5m      {�5n      �� *ConnectState+# [ ��5o      �� *Remark+� 5p      $��4��5q      $��2��5r      $��0,15,0,0q�5s       5t      �� 5u      $��* �6+   �� 5v      $��* �6+   .+�5y      �� $��30��5z      $��10,0,0,0q�5{      $��0q�5|      $
��Left=�5}      
������ $��0q�5      ��5�      �� *BeginCommand+ � FocusVisualStyle 5�      Z� ��5�      �� 5�       �� 
TargetType" ��6$   .�5�   "   �� 	 �� Property	 � ��
 �� Value
 5�   &   �� 5�   *   $��30��60   $!��/Resourecs/Images/Start.png��6;   5�   #    �� Triggers 5�   "   �� 5�   &    �� Binding 62   �� *ConnectState+ �� Value True6S   .a�5�   *   �� 	 � ��
 5�   .   �� 5�   2   $��30��68   $ ��/Resourecs/Images/Stop.png��6C   5�   +   5�   '   5�      5�      �� 5�      $��1��5�      $��0,0,30,0q�5�      ���#409EFF$��0q�5�      $��保存��5�      ���#FFFFFF��5�      �� *SaveCommand+5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ ProgramDataGrid��5�      $��5��5�      $��2��5�      $��5,10,5,5q�5�         AutoGenerateColumns$ False��5�         CanUserAddRows$ False��5�         GridLinesVisibility$	 All=�5�         HeadersVisibility$ Column=�5�         
IsReadOnly$
 True��5�      $
��Auto=�5�      $
��Auto=�5�         SelectionMode$ Single=�5�         SelectionUnit$ FullRow=�5�      ��5�      �� *	IPLists+ 5�      �� *SelectedIPIterm+ �� Mode$ TwoWay=�   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 5�         Header$ ID��5�      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�      �� *ID+5�        5�      $ 50 5�      $ 	程序名��5�       5�      �� *ProgramName+5�        5�      $	 100 5�      $ IP地址��5�       5�      �� *	IPAddress+5�        5�      $ 80 5�      $ 端口��5�       5�      �� *Port+5�        5�      $	 100 5�      $ 备注��5�       5�      �� *	Remarks+5�      5�      5�      5�      � 5�   
   $��1��6    5�      �� 5�      $��* �6    �� 5�      $��40 �6    .+�5�      �� $��0��5�      $��5q�5�      $��消息记录��5�      .��5�      �� -   5         ��Name$ MessageTextBox��5�       �� AcceptsReturn$
 True��5�      $��Consolas)�5�      $��14(�5�       �� 
IsReadOnly$
 True��5�       �� TextWrapping$
 Wrap=�5�      " �� VerticalScrollBarVisibility$
 Auto=�5�      ��5�      �� *MessageData+  �� UpdateSourceTrigger$  PropertyChanged=�5�      5�      �� 5�      $��1��5�      $��5q�5�      ! �� Orientation$! 
Horizontal=�5�      .+�5�      �� $	��200��5�      $��Center=�5�      $��Consolas)�5�      $��14(�5�      $
 Wrap=�5�      $
 Auto=�5�      ��5�      �� *SendmessaggeData+5�      �� 5�      $��72��5�      $��30��5�      $��10,0,0,0q�5�      ���#409EFF$��0q�5�      $��发送��5�      ���#FFFFFF��5�      �� *SendMessageCommand+5�      5�      5�      �� 5�   
   $��2��5�      $��5q�5�      $��日志记录��5�      .��5      �� -   5        $ 
LogTextBox��5     $
 True��5     $��Consolas)�5     $��14(�5     $
 True��5     $
 Wrap=�5     $
 Auto=�5	     ��5     �� *	LogData+$  PropertyChanged=�5	     5
     5     5     