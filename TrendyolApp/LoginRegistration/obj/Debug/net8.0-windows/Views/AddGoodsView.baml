   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5      ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  6<   $    TrendyolApp.Views.AddGoodsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:TrendyolApp.Views  5      5
viewmodels$clr-namespace:TrendyolApp.ViewModels  6<   .��5
      �   � RowDefinitions  5   
   �� 5      �� 5      $	��350 �6   �� 5      .+�5   
   �� $��1��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,0&�67   .��5      �  � Color$ #FFFF��6#    � Offset$
 -0.5Q�61   � 5      $ #F27A1A��6#   $ 1Q�63   5      ._�5      � $��1��6    � ColumnDefinitions 5      �� 5      �� 5      $	��400 �6'   �� 5      .+�5       �� $��1��6   .+�5!      �� $��1��6   $	��240��6.   $��60��6:   $��Center=�6F   $	��Top=�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Name of Product��6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 ����� !  MaterialDesignOutlinedTextBox#��[  6�   ��6c   �� *ProductNameText+6�   �� 5"      $��1��6   $	��240��6.   $��60��6:   $��Center=�6n   $	��Top=�6�   $ Model of Product��6�   
 �����#��[  6�   $��0 10 0 0q�65  ��6F   �� *ProductDescriptionText+65  �� 5#      $��70��6   $��60��6)   $ Price��6W   
 �����#��[  6�   $��
0 10 170 0q�6�   ��65   �� *ProductPriceText+6�   �� 5$      $	��164��6   $��60��6*   $ Type of Product��6W   
 �����#��[  6�   $��-10 -60 -80 0q�6�   ��66   �� *ProductTypeText+6�   �� 5%      $��70��6   $��60��6)   $ Count��6X   
 �����#��[  6�   $��
0 10 170 0q�6�   ��66   �� *ProductCountText+6�   �� 5&      $	��150��6   
������ $��Right=�6_   
������ 
���   �$��Add Product��6�   $��40��6�   ��6)   �� *
AddOrder+6�   5'      �� 5(      $��Browse��6   
�������
������ $��1��6v   $��Right=�6�   $	��Top=�6�   $��	0,196,0,0q�6�   ��6V   �� *BrowseImage+6�   �� 5*      $��2��69   $	��Top=�6J   $	��200��6b   $	��300��6n   $��0,10,0,0q�6{   ��6   �� *SelectedImage+6{   5+      5,      �� 5.   
   $��0��6   ��5/      �� 50      $	 0,0&�6&   $	 1,0&�67   .��51      � $ #F27A1A��6#   $ 1Q�63   � 52      $ #FFFF��6#   $
 -0.5Q�61   53      ._�55      � .+�56      �� $��60��6   $
��Left=�6$   $
��Back��6?   
������ 
������ 
���   ���6�   �� *Back_Button+�� 57      $��0��6   $��1��6)   $��Want To Add a Product?��69   $��Center=�6W   $��35(�6t   58      59      �� 5;   
   $��2��6   ��5<      �� 5=      $	 0,0&�6&   $	 1,0&�67   .��5>      � $ #FFFF��6#   $
 -0.5Q�61   � 5?      $ #F27A1A��6#   $ 1Q�63   5@      5B      5C      5D      