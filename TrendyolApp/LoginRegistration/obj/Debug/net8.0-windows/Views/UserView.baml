   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TrendyolApp.Services.ClassesTrendyolApp.Services.Classes  5      5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5      ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  6<        TrendyolApp.Views.UserView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      3sv*clr-namespace:TrendyolApp.Services.Classes  5      +localclr-namespace:TrendyolApp.Views  5      5
viewmodels$clr-namespace:TrendyolApp.ViewModels  6<   
�������  � 	Resources  5      5   /TrendyolApp.Services.Classes.ContextMenuBinding   ContextMenu   Data��%+   &	          5   
    64   �� 6G   5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��670 �6   .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      .+�5%      �� $��/Images/ty-web.png��6   �� 5'      $��1��6   $	��300��6"   $��60��6.   
������ ���#afb2bc ) %MaterialDesignFlatSecondaryDarkButton#��[ 6h   $	��All��6�   $��18(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6  $	��All��6=  ��6  �� *ShowGoodsByType+6=  �� 5(      $��2��6   $	��300��6"   $��60��6.   
������ ���#afb2bc#��[ 6h   $!��Smartphones and Accessories��6�   $��18(�6�   $��Center=�6�   $��Center=�6  $
��Bold"�6  $!��Smartphones and Accessories��6U  ��61  �� *ShowGoodsByType+6U  �� 5)      $��3��6   $	��300��6"   $��60��6.   
������ ���#afb2bc#��[ 6h   $��Smart Gadjets��6�   $��18(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6  $��Smart Gadjets��6G  ��6#  �� *ShowGoodsByType+6G  �� 5*      $��4��6   $	��300��6"   $��60��6.   
������ ���#afb2bc#��[ 6h   $��Laptops, PC, Tablets��6�   $��18(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6  $��Laptops, PC, Tablets��6N  ��6*  �� *ShowGoodsByType+6N  �� 5+      $��5��6   $	��300��6"   $��60��6.   
������ ���#afb2bc#��[ 6h   $��Gaming Devices��6�   $��18(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6  $��Gaming Devices��6H  ��6$  �� *ShowGoodsByType+6H  �� 5,      $��6��6   $	��300��6"   $��60��6.   
������ ���#afb2bc#��[ 6h   $��TV, Audio, Photo��6�   $��18(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6  $��TV, Audio, Photo��6J  ��6&  �� *ShowGoodsByType+6J  �� 5-      $��7��6   $	��300��6"   $��60��6.   
������ ���#afb2bc#��[ 6h   $��Kitchen Appliances��6�   $��18(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6  $��Kitchen Appliances��6L  ��6(  �� *ShowGoodsByType+6L  �� 5.      $��8��6   $	��300��6"   $��60��6.   
������ ���#afb2bc#��[ 6h   $��Home Appliances��6�   $��18(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6  $��Home Appliances��6I  ��6%  �� *ShowGoodsByType+6I  �� 5/      $��9��6   $	��300��6"   $��60��6.   
������ ���#afb2bc#��[ 6h   $��Automobile Products��6�   $��18(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6  $��Automobile Products��6M  ��6)  �� *ShowGoodsByType+6M  50      � 52   
   $��1��6    53      �� 54      $��30 �6    �� 55      $��60 �6    �� 56      $��* �6    .+�5;      �� $��1��6   $	��350��6#   $��40��6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��6;   
�������$��20(�6n   $��	0,5,320,5q�6�   ��6|   �� *
SearchText+6�   �� 5<      $��1��6   $��57��6"   $��40��6-   $
��🔍��69   $��Center=�6a   $
��Left=�6|   $��	350,0,0,0q�6�   ���#0ba38b
������ ��6F   �� *Search+6�   �� 5=      $��1��6   $��57��6"   $��40��6-   $��×��69   $��25(�6E   $��Center=�6q   $
��Left=�6�   $��	288,0,0,0q�6�   
������ 
������ ��6S   �� *	ClearText+6�   �� 5>      $��1��6   $��57��6%   ���#0ba38b$��40��6E   $��Center=�6v   $
��Left=�6�   $��	495,0,0,0q�6�    �� TextAlignment$ Center=�6�   $��20(�6�   ��6Q   �� *CurrentUser.Balance+6�   �� 5?      $��1��6   $��Right=�6"   ���#0ba38b
������ $��Center=�6m   $	��Buy��6�   $��20(�6�   $��40��6�   ��6�   �� *
Buy_Button+6�   �� 5@      $��1��6   $��48��6"   $��40��6-   ���#0ba38b
������ $	��♡��6h   $��25(�6t   $��Center=�6�   $
��Left=�6�   $��	557,0,0,0q�6�   ��6�   �� *LikedProductView+�� 5A      $��1��6   $��78��6"   $��Profile��6-   ���#0ba38b
������ $��40��6n   $��Center=�6z   $
��Left=�6�   $��	412,0,0,0q�6�     menuBar#��[ 6�    � ContextMenu 5B      �� 5C      -   5         ��Name$ ProfileContextMenu��5C   "   .@�5D      m� $��Orders��6#    m� Command 63   �� 	 �� Source#	 [  
 �� Path$
 Data.OrdersView�m� 5E      $��Profile��6#    64   �� #	 [  $
 Data.UserInfoView_Button�m� 5F      $��Balance��6#    64   �� #	 [  $%
 Data.IncreaseBalanceView_Button�m� 5G      $��	Balance: ��6#    66   �� #	 [  $
 Data.CurrentUser.Balance�m� 5H      $��Sign out��6#   
���  �� 6F   �� #	 [  $
 Data.SignOut_Button�5I      5K      �� 5N      $��2��6   $��Stretch=�5O   
   ��5N   #   �� *Goods+ �� SelectedItem 6A   �� *SelectedProduct+��5P      �� 5Q       �� 
TargetType" ��6   .�5R      ��  �� Property � �� �� Value$ 5q�63   �� 5S       � ��
 ���� 68   �� 5T       � ��$ 1q�6<   �� 5U       � ��$ 5q�64   5V      ��5X      �� 5Y      .R�5Z      � .+�5[      �� 
���   �$��1q�69   ._�5\   "   �  5]   &   �� 5^   *   $��* �68   �� 5_   *   $
��Auto �68   .+�5a   &   �� $��0��61    �� Orientation$ 
Horizontal=�6>   .+�5b   *   �� $	��150��60   $	��150��6<   $��UniformToFill=�6f   ��6I   �� *	ImageData+6f   �� 5c   *   $��5q�65   .+�5d   .   �� $ 
Horizontal=�69   .+�5e   2   �� $
��Bold"�6<   $��Name: ��6N   �� 5f   2   ��6<   �� *Name+5g   /   �� 5h   .   $ 
Horizontal=�69   .+�5i   2   �� $
��Bold"�6<   $��Description: ��6N   �� 5j   2   ��6<   �� *Description+5k   /   �� 5l   .   $ 
Horizontal=�69   .+�5m   2   �� $
��Bold"�6<   $��Product Type: ��6N   �� 5n   2   ��6<   �� *ProductType+5o   /   �� 5p   .   $ 
Horizontal=�69   .+�5q   2   �� $
��Bold"�6<   $��Price: ��6N   �� 5r   2   ��6<   �� *Price+5s   /   5t   +   5u   '   �� 5y   &   $��0��6-   $��Right=�6:   $��-��6V   ���#0ba38b
������ $	��Top=�6�   $��Minus��6  ��6�   �� * DataContext.AddOrRemoveProduct+ �� RelativeSource ��  �� AncestorType ListBox6  �� 5z   &   $��0��6-   $��Right=�6:   $��+��6V   ���#0ba38b
������ $	��Top=�6�   $��0 0 50 0q�6  $
��Plus��6$  ��6�   �� * DataContext.AddOrRemoveProduct+ ��  ListBox6$  5{   #   5|      5}      5~      5�      5�      5�      5�      