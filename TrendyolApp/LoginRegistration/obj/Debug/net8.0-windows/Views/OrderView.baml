   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5      ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  6<   !    TrendyolApp.Views.OrderView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:TrendyolApp.Views  5      5
viewmodels$clr-namespace:TrendyolApp.ViewModels  6<   .��5V      �   � ColumnDefinitions  5W   
   �� 5X      �� 5Y      $	��560 �6   .+�5\   
   �  � RowDefinitions 5]      �� 5^      �� 5_      $	��520 �6    �� 5`      .+�5c      �� $��50��6   $
��Left=�6    $	��←��6;   ���#748ce3��6\   �� *Back_Button+�� 5e      $��1��6   ��6!   �� *CurrentProduct.ImageData+5f      � 5h   
   $��1��6    5i      �� 5j      $��30 �6    �� 5k      �� 5l      �� 5m      .+�5p      � $��2��6     5q      �� 5r      �� 5s      $	��200 �6'   .+�5v      �� $��1��6   
�������._�5w      ��  �� Orientation$ 
Horizontal=�6!   .+�5x      �� $	��Top=�6!   
������ 
������ $��-��6l   
���   �$��25(�6�   $��Center=�6�   $��Decrease��6�   $��Center=�6  $��40��6%  ��6�   �� *IncreaseDecreaseCount+6%  �� 5y      $��20��6$   $��20��6/   $��0 15 0 0q�6;   $	��Top=�6M   
���   � �� TextAlignment$ Center=�6x   ��6�   �� *ProductCount+�� 5z      $	��Top=�6!   
������ 
������ $��+��6l   
���   �$��0 2 0 0q�6�   $��21(�6�   $��Increase��6�   $��Center=�6�   $��Center=�6  $��40��66  ��6�   �� *IncreaseDecreaseCount+66  5{      5|      5}      �� 5      $��1��6   $	��250��6%   $��60��61   $��20(�6=   $
��Left=�6K   $��
10,90,0,73q�6�   ��6f   �� *CurrentProduct.Name+6�   �� 5�      $��1��6   $	��250��6%   $��60��61   $��15(�6=   
�������$
��Left=�6]   $��Bottom=�6x   $��10,0,0,0q�6�   ��6�   �� *CurrentProduct.Description+6�   �� 5�      $��2��6   $	��200��6"   $��50��6.    �� CornerRadius$ 10��6:   ���#748ce3$��2q�6b   $
��Left=�6v   $��Center=�6�   ._�5�      �� $��2��6   $	��200��6&   $��45��62   ���#748ce3$	��Buy��6S   $��20(�6a   ��6o   �� *
Buy_Button+5�      �� 5�      $��1��6   $	��250��6%   $��60��61   $
��Left=�6=   $	��Top=�6X   $��20(�6�   $��
10,223,0,0q�6�   $��2��6�   ��6p   �� *CurrentProduct.Price+6�   �� 5�      $��1��6   $��50��6%   $��60��60   $
��Left=�6<   $	��Top=�6W   $��$��6o   $��20(�6x   $��
55,223,0,0q�6�   $��2��6�   �� 5�      $��2��6   $��60��6"   $��50��6-   $��Center=�69   
�������
�������$	��♡��6�   $��25(�6�   �� 5�      $��3��6   ��5�      �� *Goods+ �� SelectedItem 5�      �� *SelectedProduct+��5�      �� 5�      .R�5�      �� $ 
Horizontal=�6%   5�      ��5�      �� 5�      .R�5�      � $��5q�6    5�      �� 5�   "   $��* �60   �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   .+�5�      �� $��0��6$   $	��100��6N   $	��100��6Z   ��61   �� *	ImageData+6Z   �� 5�      $��1��6(   ��65   �� *Description+�� 5�      $��2��6(   ��65   �� *Price+5�      5�      5�      5�      5�      5�      