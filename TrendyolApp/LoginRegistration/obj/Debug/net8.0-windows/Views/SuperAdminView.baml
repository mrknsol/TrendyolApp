   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5      ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  6<   &     TrendyolApp.Views.SuperAdminView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TrendyolApp.Views     5      ;
viewmodels$clr-namespace:TrendyolApp.ViewModels     6<   .��5      �   � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��110 �6   .+�5   
   �� $��0��6   $	��380��6   $
��Left=�6+   ��6F   �� *
SearchText+�� 5   
   $��0��6   $
��Left=�6@   $��80��6[   $��Search��6f   $��
380,8,0,10q�6w   ��6   �� *Search_Button+6w   �� 5   
   $��1��6   $��0,0,40,0q�6   ._�5      � $��0,0,36,0q�6   .+�5      �� $��2��6   $��Stretch=�5      ��5   '   �� *Users+ �� SelectedItem 6E   �� *SelectedUser+��5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$ 5q�67   �� 5       � ��
 ���� 6<   �� 5       � ��$ 1q�6@   �� 5        � ��$ 5q�68   5!      ��5#      �� 5$      .R�5%      � .+�5&   "   �� 
�������$��1q�6=   ._�5'   &   �   5(   *   �� 5)   .   $��* �6<   �� 5*   .   $
��Auto �6<   .+�5,   *   �� $��0��65    �� Orientation$ 
Horizontal=�6B   .+�5-   .   �� $	��150��64   $	��150��6@   $��UniformToFill=�6m   ��6M   �� *ProfileImage+6m   �� 5.   .   $��5q�69   .+�5/   2   �� $ 
Horizontal=�6=   .+�50   6   �� $
��Bold"�6@   $��Name: ��6R   �� 51   6   ��6@   �� *Name+52   3   �� 53   2   $ 
Horizontal=�6=   .+�54   6   �� $
��Bold"�6@   $��	Surname: ��6R   �� 55   6   ��6@   �� *	Surname+56   3   �� 57   2   $ 
Horizontal=�6=   .+�58   6   �� $
��Bold"�6@   $��
Username: ��6R   �� 59   6   ��6@   �� *
Username+5:   3   �� 5;   2   $ 
Horizontal=�6=   .+�5<   6   �� $
��Bold"�6@   $��Email: ��6R   �� 5=   6   ��6@   �� *Email+5>   3   �� 5?   2   $ 
Horizontal=�6=   .+�5@   6   �� $
��Bold"�6@   $��Membership: ��6R   �� 5A   6   ��6@   �� *
Membership+5B   3   5C   /   5D   +   5E   '   5F   #   5G      5H      5J      5O      5P      � 5Q   
   $��2��6     5R      �� 5S      �� 5T      �� 5U       5W      �� 5X      �� 5Y      .+�5[      	� $��2��6   $��0��6'   $
��User��67   ��5\      �� *ChangeToUserCommand+	� 5]      $��2��6   $��1��6'   $��Admin��67   ��5^      �� *ChangeToAdminCommand+5_      �� 5a   
   $��1��6   $��1��6!   $	��Out��6.   $��
0,92,0,196q�6[   ��6<   �� *
Out_Button+6[   �� 5b   
   $��1��6   $��1��6!   $	��Top=�6.   $��Create User��6F   ��6\   �� *CreateUser_Button+�� 5c   
   $��1��6   $��1��6!   $	��Top=�6.   $��Delete User��6F   $��0,44,0,0q�6�   ��6\   �� *DeleteUser_Button+6�   5d      5e      