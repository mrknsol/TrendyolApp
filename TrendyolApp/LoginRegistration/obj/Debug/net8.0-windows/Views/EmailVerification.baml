   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TrendyolAppTrendyolApp  5   	   ?$clr-namespace:TrendyolApp.ViewModelsTrendyolApp.ViewModels  5   	   )    #TrendyolApp.Views.EmailVerification   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:TrendyolApp  5   	   5
viewmodels$clr-namespace:TrendyolApp.ViewModels  5   	   $	��700��5
      $	��950��6'   ���#6ccbc3.��5      �   � ColumnDefinitions  5Q   
   �� 5R      �� 5S      $	��450 �6   .+�5V   
   � $��1��6    � RowDefinitions 5W      �� 5X      �� 5Y      �� 5Z      �� 5[      �� 5\      .+�5`      �� $��1��6   $��1��6%   $��3��62    �� CornerRadius$ 10��6C   
�������$��1q�6h   ��5a      �� 5b       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 1,0&�6;   .��5c      �  � Color$ #FFFF��6'    � Offset$ 0Q�65   � 5d      $ #6ccbc3��6'   $ 1Q�67   5e      ._�5g      � .+�5i      �� $��Forgot Password?��6    $��1��68   $��25(�6E   ���#f38047$
��Bold"�6h   $��25,29,-25,-29q�6z   �� 5j      $��Let's Restore��6    $��35(�65   ���#f38047$
��Bold"�6X   $��25,54,-25,-54q�6j   �� 5k      $ 10��6   
�������$��1q�6B   $	��350��6V   $��35��6b   
�������._�5l      �� $��1��6"   $��35��6/   
������ )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter Email��6q   $��20(�6�   $��Center=�6�   $
��Left=�6�   $��	9,-1,9,-1q�6�   ��6;   �� *CurrentText+6�   5m      �� 5n      $ 10��6   
�������$��1q�6B   $��33��6V   $��30��6a   $
��Left=�6m   ���#f38047$��405,194,0,194q�6�   ._�5o      �� $��Center=�6!   $��51��6<   $��30��6G   $��Center=�6S   
������ $	��✔��6�   $��15(�6�    J� RenderTransformOrigin$ 	0.242,0.5&�6�   ��6�   �� *SendVerificationCode_Button+6�   5p      �� 5r      $ 10��6   
�������$��1q�6B   $	��350��6V   $��35��6b   
�������$��50,180,50,54q�6�   ._�5s      �� $��2��6"   $��35��6/   
������ $ Enter Code:��6q   $��20(�6�   $��Center=�6�   $
��Left=�6�   $��	9,-1,9,-1q�6�   ��6;   �� *EnteredCode+6�   5t      �� 5w      $ 10��6   
�������$��1q�6B   $	��150��6V   $��60��6b   ���#f38047$��150,279,150,-54q�6�   ._�5x      �� $��Verify!��6!   $��25(�63   $��70��6A   
�������$
��Bold"�6`   
������  )  %MaterialDesignFlatSecondaryDarkButton#��[  6�   $��	0,-1,0,-1q�6�   ��6�   �� *VerifyCode_Button+6�   5y      5{      5|      5      �� 5�   
   $��0��6   $��/Images/Undraw-02.png��6    $	��500��6?   $	��700��6K   $��0 0 0 40q�6X   �� 5�   
   $ 10��6   $	��150��6#   $	��110��6/   
�������$��1q�6O   ���#f38047$��-46,-30,396,620q�6x   ._�5�      �� $��25(�6   $	��150��6#   $��75��6/   
�������$
��Bold"�6N   
������ #��[  6y   $��27,29,-1,16q�6�   ��6�   �� *Back_Button+.��5�      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 ArrowBackCircle=�6   $��50��65   $��60��6@   $��Center=�6L   5�      5�      5�      5�      