   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TrendyolAppTrendyolApp  5   	   ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  5   	   &     TrendyolApp.Views.ForgotPassword   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:TrendyolApp  5   	   5
viewmodels$clr-namespace:TrendyolApp.ViewModels  5   	   $	��450��5
      $	��800��6'   .��5      �   � ColumnDefinitions  5Q   
   �� 5R      $	��450 �6   �� 5S       � RowDefinitions 5V   
   �� 5W      �� 5X      �� 5Y      �� 5Z      �� 5[      .+�5^   
   �� $��1��6   $��Change Password��6!   $��Center=�68   $��Center=�6U   $��45(�6p   $��Normal"�6~   �� 5_   
   $��2��6   $��Password must contain: ��6!   $
��Left=�6@   $	��Top=�6[   $��17(�6s   
�������$��Normal"�6�   $��50,0,0,0q�6�   �� 5`   
   $��2��6   $��• At least 8 characters��6!   $	��Top=�6@   $��14(�6X   $��2��6f   $��Normal"�6z   
�������$��64,26,286,0q�6�   �� 5a   
   $��2��6   $&�� • At least 1 upper case letter��6!   $	��Top=�6G   $��14(�6_   $��2��6m   $��Normal"�6�   
�������$��64,45,286,0q�6�   �� 5b   
   $��2��6   $&�� • At least 1 lower case letter��6!   $	��Top=�6G   $��14(�6_   $��2��6m   $��Normal"�6�   
�������$��64,64,286,0q�6�   �� 5c   
   $��3��6   $��• At least 1 number��6!   $	��Top=�6<   $��14(�6T   $��2��6b   $��Normal"�6v   
�������$��
64,0,-64,0q�6�   �� 5e   
   $��1��6   $��1��6   $	��300��6/   $��65��6;   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ New Password��6G    !  MaterialDesignOutlinedTextBox#��[  6�   ��6i   �� *PasswordText+6�   �� 5f   
   $��2��6   $��1��6   $	��300��6/   $��65��6;   $ Confirm Password��6G   #��[  6�   ��6m   �� *ConfirmText+6�   �� 5h   
   $��3��6   $��1��6   $	��300��6.   $��65��6:   $
��Save��6F   $��25(�6U   ���#6B9ADC ) %MaterialDesignFlatSecondaryDarkButton#��[ 6�   
���������6x   �� *ResetPassword_Button+6�   �� 5i   
   $��4��6   $��1��6   $	��300��6.   $��65��6:   $��Cancel��6F   $��25(�6W   
������ #��[ 6�   
���������6~   �� *BackToLoginPage_Button+6�   5l      5m      