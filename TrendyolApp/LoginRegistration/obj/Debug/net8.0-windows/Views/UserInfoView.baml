   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5      ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  6<   $    TrendyolApp.Views.UserInfoView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TrendyolApp.Views     5      ;
viewmodels$clr-namespace:TrendyolApp.ViewModels     6<   .��5&      �   � ColumnDefinitions  5'   
   �� 5(      �� 5)      $	��700 �6   .+�5-   
   �  � RowDefinitions 5.      �� 5/      $��70 �6    �� 50      .+�53      ��  �� Orientation$ 
Horizontal=�6   .+�54      �� $��60��6   $
��Back��6$   ���#0ba38b��6H   �� *Back_Button+�� 55      $��Private Info��6   $
��Bold"�60   $��	10 20 0 0q�6B   $��25(�6U   56      �� 58      $��1��6   $	��200��6!   $	��200��6.   $��
0,35,0,495q�6;   ��6O   �� *CurrentUser.ProfileImage+59      � 5;   
   $��1��6    5=      �� 5>      �� 5?      �� 5@      �� 5A      �� 5B      .+�5D      �� $��Name : ��6   $	��150��6'   $
��Left=�63   $��Center=�6N   $��30(�6i   �� 5E      $��1��6   $��
Surname : ��6%   $	��150��67   $
��Left=�6C   $��Center=�6^   $��30(�6y   �� 5F      $��2��6   $��Username : ��6%   $	��150��68   $
��Left=�6D   $��Center=�6_   $��30(�6z   �� 5G      $��3��6   $��Email : ��6%   $	��150��65   $
��Left=�6A   $��Center=�6\   $��30(�6w   �� 5H      $��4��6   $��Save Changes��6"   $	��250��69   ���#0ba38b$��50��6Z   $
��Left=�6f   $��Center=�6�   $��30(�6�   ��6�   �� *SaveChanges_Button+6�   �� 5K      $	��250��68   $
��Left=�6D   $��Center=�6_   $��30(�6z   $��	125,0,0,0q�6�   ��6   �� *CurrentUser.Name+6�   �� 5L      $��1��6   $	��250��6H   $
��Left=�6T   $��Center=�6o   $��30(�6�   $��	150,0,0,0q�6�   ��6#   �� *CurrentUser.Surname+6�   �� 5M      $��2��6   $	��250��6I   $
��Left=�6U   $��Center=�6p   $��30(�6�   $��	156,0,0,0q�6�   ��6#   �� *CurrentUser.Username+6�   �� 5N      $��3��6   $	��400��6F   $
��Left=�6R   $��Center=�6m   $��30(�6�   $��	100,0,0,0q�6�   ��6#   �� *CurrentUser.Email+6�   5O      5Q      5R      