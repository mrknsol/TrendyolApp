   M S B A M L   `   `   `  ����F  BTrendyolApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TrendyolApp.ViewsTrendyolApp.Views  5   	   "    TrendyolApp.Views.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   +localclr-namespace:TrendyolApp.Views  5   	   -   5          � Title$  
MainWindow��5	   	   $	��700��5   	   $	��950��6    � 
ResizeMode$ CanMinimize=�5   	    � WindowStyle$
 None=�5   	   .��5      � .+�5   
   �� $��0��6   $��4��6&   $��2��67   ��6G   �� *CurrentView+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   -   5        $
��Quit��5      
������� #  MaterialDesignFlatLightBgButton#��[  5   	   $��Right=�5      $��0 0 0 0q�5      
������ 
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5      $	��Top=�5      $��28��6   $��52��6*   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�5    	   $��25��6   $��34��6"   $��Center=�6-   $��Center=�6H   5!      �� 5#   
   -   5        $��Minimize��5$      
�������#��[  5&      $��Right=�5'      
������ 
������ $��0 0 30 0q�5*      $ 10��5+      $	��Top=�5,      $��28��6   $��47��6%   .��5-        $ Minimize=�5.      $��25��6   $��34��6    $��Center=�6+   $��Center=�6F   5/      50      51      