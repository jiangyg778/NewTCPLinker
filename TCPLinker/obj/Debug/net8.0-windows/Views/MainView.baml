   M S B A M L   `   `   `  ����D  @TCPLinker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TCPLinker.Base.ConvertersTCPLinker.Base.Converters  5      1clr-namespace:TCPLinker.ViewsTCPLinker.Views  5          TCPLinker.Views.MainView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      5c'clr-namespace:TCPLinker.Base.Converters     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:TCPLinker.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      \ XPrism.Unity.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59V RPrism.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5	        � Title$  MainView��5
      $	��900��5      $	��550��5       � 
ResizeMode$ NoResize=�5       � 	Resources 5      2  ,TCPLinker.Base.Converters.ImagePathConverter   ImagePathConverter<   6TCPLinker.Base.Converters.HtmlEntityToUnicodeConverter   HtmlEntityToUnicodeConverter��%:   &	        &	        5   
   6     5   
   6)   5      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���#79BBFF6   �� 5   
   $��0��5      $��60,0,0,0q�5      $
��Left=�5      $
��Left=�5      
������ 
������ $��0q�5!      ��5"      �� *	MenuItems+��5#      �� 5$      .R�5%      ��  �� Orientation$ 
Horizontal=�6!   5&      ��5(      �� 5)      .R�5*      �� 
������ 
������ $��0q�5-      ��5.      �� *DataContext.SelectMenuCommand+ �� RelativeSource ��  �� AncestorType
 Window��5/      �� ��51      �� 52      .R�53   "   �� $��30��54   %    �� Padding$ 5q�55   %   
������� �� CornerRadius$ 5��57   %   ._�58   &   �� $��Center=�59   )   $��Center=�5:   )   $ 
Horizontal=�5;   )   .+�5=   *   �� $��0,0,5,0q�5>   -    	 Icons#��[ 5?   -   $��18(�5@   -   ��5A   -   �� *
IconName+	 �� 	Converter#	 [ �� 5B   *   $��14(�64   ��6B   �� *Name+5C   '   5D   #   5E      5G      5H      5J      �� 5K   
   $��1��6   ,  &Prism.Navigation.Regions.RegionManager
   
RegionName$
 
MainRegion��6&   5M      5N      