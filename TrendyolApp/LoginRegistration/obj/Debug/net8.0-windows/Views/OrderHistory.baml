   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5      ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  6<   $    TrendyolApp.Views.OrderHistory   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TrendyolApp.Views     5      ;
viewmodels$clr-namespace:TrendyolApp.ViewModels     6<   
�������.��56      �   � ColumnDefinitions  57   
   �� 58      �� 59      $	��700 �6    � RowDefinitions 5<   
   �� 5=      $��60 �6   �� 5>      .+�5B   
   �� $��/Images/ty-web.png��6   �� 5C   
   $��50��6   $
��Left=�6   $	��←��67   ���#748ce3��6C   �� *Back_Button+6c   �� 5D   
   $��1��6   $��1��6   $��Stretch=�5E      ��5D   /   �� *Orders+��5F      �� 5G       �� 
TargetType" ��6   .�5H      ��  �� Property � �� �� Value$ 5q�6/   �� 5I       � ��
 ���� 64   �� 5J       � ��$ 1q�68   �� 5K       � ��$ 5q�60   5L      ��5N      �� 5O      .R�5P      � .+�5Q      �� 
������ $��1q�6;   ._�5R      �  5S   "   �� 5T   &   $��* �64   �� 5U   &   $
��Auto �64   .+�5W   "   �� $��0��6-    �� Orientation$ 
Horizontal=�6:   .+�5X   &   �� $	��150��6,   $	��150��68   $��UniformToFill=�6h   ��6E   �� *Goods.ImageData+6h   �� 5Y   &   $��5q�61   .+�5Z   *   �� $ 
Horizontal=�65   .+�5[   .   �� $
��Bold"�68   $��Name: ��6J   �� 5\   .   ��68   �� *
Goods.Name+5]   +   �� 5^   *   $ 
Horizontal=�65   .+�5_   .   �� $
��Bold"�68   $��Description: ��6J   �� 5`   .   ��68   �� *Goods.Description+5a   +   �� 5b   *   $ 
Horizontal=�65   .+�5c   .   �� $
��Bold"�68   $��Product Type: ��6J   �� 5d   .   ��68   �� *Goods.ProductType+5e   +   �� 5f   *   $ 
Horizontal=�65   .+�5g   .   �� $
��Bold"�68   $��Price: ��6J   �� 5h   .   ��68   �� *Goods.Price+5i   +   5j   '   5k   #   5l      5m      5n      5o      5q      5r      5s      