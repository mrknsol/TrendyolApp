   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5      ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  6<   !    TrendyolApp.Views.AdminView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TrendyolApp.Views     5      ;
viewmodels$clr-namespace:TrendyolApp.ViewModels     6<   .��5	      �   � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��120 �6   .+�5   
   �� $��0��6   $	��380��6   $��20(�6+   $
��Left=�69   $��Bottom=�6[   $
��Left=�6�   ��6}   �� *
SearchText+6�   �� 5   
   $��0��6   $
��Left=�6   $��80��69   $��Search��6D   $��
380,8,0,10q�6U   ��6i   �� *Search+�� 5   
   $��0��6   $��80��6   $��465,8,135,10q�6)   $��Clear��6?   ��6O   �� *	ClearText+�� 5   
   $��1��6   ._�5      � .+�5      �� $��1��6   .��5      �� $��1��6   $	��448��5   1   ��5   
   �� *Orders+ �� SelectedItem 5   
   �� *SelectedOrder+��5      �� 5      .R�5    "   �  5!   &   �� 5"   *   �� 5#   *   .+�5%   &   ]� .+�5'   *   �� $��0��66   $
��Left=�6F   .+�5(   .   �� $��Login: ��64   �� 5)   .   $��	Product: ��64   �� 5*   .   $��Status: ��64   5,   +   �� 5-   *   $��1��65   $	��Top=�6E   .+�5.   .   �� ��64   �� *Users.Username+�� 5/   .   ��64   �� *
Goods.Name+�� 50   .   ��64   �� *Status+53   +   54   '   56   #   58      5:      5;      5<      5=      � 5>   
   $��2��6     5?      �� 5@      �� 5A      �� 5B       5E      �� 5F      �� 5G      �� 5H      �� 5I      �� 5J      �� 5K      .+�5N      	� -   5        $��InAbroadWareHouse��5N      $��1��64   $
��Left=�6A   $��In abroad warehouse��6�   $��2��6
  $��14,0,0,0q�6  ��6\   �� *Check+��6v   ��  �� RelativeSource �� *Self+ d� 	IsChecked 6�   �� *RadioButton.InAbroadWareHouse+6  	� 5O      -   5        $��Shipped��5O      $��1��6)   $��1��66   $
��Left=�6G   $��Shipped��6�   $��52,0,0,0q�6�   $��2��6  $��81��6!  ��6c   �� *Check+��6}   ��  �� *Self+ 6�   �� *RadioButton.Shipped+6!  	� 5P      -   5        $��InFilial��5P      $��1��6*   $��2��67   $
��Left=�6G   $��
In fillial��6�   $��26��6�   $��Center=�6  $��43,0,0,0q�6&  ��6c   �� *Check+��6}   ��  �� *Self+ 6�   �� *RadioButton.InFilial+6&  	� 5Q      -   5        $��Ordered��5Q      $��1��6)   $��3��66   $��Center=�6F   $��Ordered��6�   ��6d   �� *Check+��6~   ��  �� *Self+ 6�   �� *RadioButton.Ordered+6�   	� 5R      -   5        $
��Paid��5R      $��1��6&   $��4��63   $��Center=�6C   $
��Paid��6�   ��6`   �� *Check+��6z   ��  �� *Self+ 6�   �� *RadioButton.Paid+6�   5U      �� 5V   
   $��1��6   $��Add Product��6!   $��	0,0,0,288q�6T   $��1��6g   ��67   �� *
AddGoods+6g   �� 5W   
   $��1��6   $	��Out��6!   $��
0,37,0,251q�6N   $��1��6b   ��6/   �� *
Out_Button+6b   5Y      5Z      