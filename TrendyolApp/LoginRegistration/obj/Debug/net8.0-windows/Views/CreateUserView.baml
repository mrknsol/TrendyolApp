   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5      ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  6<   &     TrendyolApp.Views.CreateUserView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      +localclr-namespace:TrendyolApp.Views  5      5
viewmodels$clr-namespace:TrendyolApp.ViewModels  6<   .��5
      �   � ColumnDefinitions  5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $
��Name��6!      text#��[  6-   $��Bottom=�6K   $��Center=�6f   �� 5   
   $��1��6   $��Surname��6!   #��[  60   $��Bottom=�6N   $��Center=�6i   �� 5   
   $��2��6   $��Username��6!   #��[  61   $��Bottom=�6O   $��Center=�6j   �� 5   
   $��3��6   $��Email��6!   #��[  6.   $��Bottom=�6L   $��Center=�6g   �� 5   
   $��4��6   $��Password��6!   #��[  61   $��Bottom=�6O   $��Center=�6j   �� 5    
   $��5��6   $��
Membership��6!   #��[  63   $��Bottom=�6Q   $��Center=�6l   �� 5"   
   $��1��6   $��0��6"   $��30��6/   $��Bottom=�6;   ��6V   �� *
NameText+�� 5#   
   $��1��6   $��1��6"   $��30��6/   $��Bottom=�6;   ��6V   �� *SurnameText+�� 5$   
   $��1��6   $��2��6"   $��30��6/   $��Bottom=�6;   ��6V   �� *	LoginText+�� 5%   
   $��1��6   $��3��6"   $��30��6/   $��Bottom=�6;   ��6V   �� *	EmailText+�� 5&   
   $��1��6   $��4��6"   $��30��6/   $��Bottom=�6;   ��6V   �� *PasswordText+	� 5(   
   $��5��6   $��1��6#   $��25(�63   $��Bottom=�6A   $
��User��6\   ��5)      �� *ChangeToUserCommand+	� 5*   
   $��5��6   $��1��6#   $��Right=�63   $��Bottom=�6O   $��25(�6j   $��Admin��6x   ��5+      �� *ChangeToAdminCommand+�� 5,   
   $��6��6   $��Cancel��6   $��20(�6/   $��1��6=   $	��150��6M   $��50��6Y   
�������$
��Left=�6w   $��Center=�6�   ��6�   �� *Back_Button+�� 5-   
   $��6��6   $
��Save��6   $��20(�6-   $��1��6;   $	��150��6K   $��50��6W   ���#07BF96$
��Left=�6x   $��Center=�6�   $��	231,0,0,0q�6�   $��2��6�   ��6�   �� *RegisterUser_Button+6�   �� 5/   
   $��2��61   $��2��6>   $	��200��6N   $	��200��6[   $��Bottom=�6g   ��6   �� *SelectedImage+6g   �� 50   
   $��3��6   $��2��6   $��Browse��6.   $��20(�6?   $	��100��6M   $��30��6Y   $
��Left=�6e   $��Center=�6�   
�������
�������$��59,0,0,0q�6�   ��6�   �� *BrowseImage+6�   52      53      