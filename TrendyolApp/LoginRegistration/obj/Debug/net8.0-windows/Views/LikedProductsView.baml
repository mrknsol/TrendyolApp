   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5      ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  6<   )    #TrendyolApp.Views.LikedProductsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TrendyolApp.Views     5      ;
viewmodels$clr-namespace:TrendyolApp.ViewModels     6<   .��5	      �   � ColumnDefinitions  5
   
   �� 5      �� 5      $	��700 �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      .+�5   
   �� $��/Images/ty-web.png��6   �� 5   
   $��50��6   $
��Left=�6   $	��←��67   ���#748ce3��6C   �� *Back_Button+6c   �� 5   
   $��1��6   $��1��6   $��Stretch=�5      ��5   /   �� *LikedProduct+ �� SelectedItem 6T   �� *SelectedProduct+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ 5q�6/   �� 5       � ��
 ���� 64   �� 5       � ��$ 1q�68   �� 5       � ��$ 5q�60   5       ��5"      �� 5#      .R�5$      � .+�5%      �� 
���   �$��1q�65   ._�5&      �  5'   "   �� 5(   &   $��* �64   �� 5)   &   $
��Auto �64   .+�5+   "   �� $��0��6-    �� Orientation$ 
Horizontal=�6:   .+�5,   &   �� $	��150��6,   $	��150��68   $��UniformToFill=�6h   ��6E   �� *Goods.ImageData+6h   �� 5-   &   $��5q�61   .+�5.   *   �� $ 
Horizontal=�65   .+�5/   .   �� $
��Bold"�68   $��Name: ��6J   �� 50   .   ��68   �� *
Goods.Name+51   +   �� 52   *   $ 
Horizontal=�65   .+�53   .   �� $
��Bold"�68   $��Description: ��6J   �� 54   .   ��68   �� *Goods.Description+55   +   �� 56   *   $ 
Horizontal=�65   .+�57   .   �� $
��Bold"�68   $��Product Type: ��6J   �� 58   .   ��68   �� *Goods.ProductType+59   +   �� 5:   *   $ 
Horizontal=�65   .+�5;   .   �� $
��Bold"�68   $��Price: ��6J   �� 5<   .   ��68   �� *Goods.Price+5=   +   5>   '   5?   #   5@      5A      5B      5C      5E      5I      5J      