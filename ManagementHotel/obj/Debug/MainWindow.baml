   M S B A M L   `   `   `  ����J  FManagementHotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ManagementHotelManagementHotel  5   	   Q-clr-namespace:ManagementHotel.UserControlXAMLManagementHotel.UserControlXAML  5   	        ManagementHotel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ManagementHotel     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   BuserControlBar-clr-namespace:ManagementHotel.UserControlXAML  5   	   -   5          �Name$  
mainWindow��5   	    
  MainVM � DataContext# [  5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Main Window��5   	   $	��450��6   $	��800��6*   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      0   *ManagementHotel.UserControlXAML.ControlBar  6*   5      � 5   
   $��1��6   ��5      �� 5       �� ImageSource$! /Images/hotelBackground.png��6   .+�5      �  J� Opacity$	 0.8Q�6   ��5      �� 5        �� 
StartPoint$	 0,1&�6*   	 �� EndPoint$		 1,0&�5!   *   .��5"      � 
 � Color$
 #060531��6'    � Offset$ 0Q�67   6D   � 5#      $
 #181448��6'   $
 0.75Q�67   6G   5$      5&      ]� 5'      $��Center=�6   $��Center=�65   .+�5(      �� 
�������$��1q�5)       �� CornerRadius$ 25��5*      ._�5+      #  MaterialDesignThemes.Wpf.Card  $	��350��6*   $	��250��67   
������ .��5-      �� .+�5.      �� $��Login��6$   $��18(�64   $
��Bold"�5/   $   $��Center=�50   $   $��	0 30 0 20q�51   $   
�������52   =   �� 53      $��	20 0 20 0q�6)   .+�54   "   �� $��	Username:��6(   $
��Bold"�55   (   
�������56   B   �� 57   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhap username��6*   
���������59   *   �� *
username+5:   ,   5;      �� 5<      $��
20 20 20 0q�6)   .+�5=   "   �� $��
Password: ��6(   $
��Bold"�5>   (   
�������5?   A   G� 5@   "   -   5         G�Name$ FloatingPasswordBox��5B   .   $ Nhap password��5@   .   
�������.  (System.Windows.Interactivity.Interaction   Triggers 5D   &   /  )System.Windows.Interactivity.EventTrigger  5E   *      	EventName$ PasswordChanged��69   .  (System.Windows.Interactivity.TriggerBase   Actions. 5F   .   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6D   �� *PasswordChangedCommand+   CommandParameter 5G   4   ��  �� ElementName$ FloatingPasswordBox��5H   +   5J   #   5K      �� 5L      -   5        $��loginButton��5P   )   $��Submit��5L   %   $��Center=�5M   )   $��0 30 0 0q�5N   )   
����+��$	��100��5Q   )    � ToolTip$4 .Resource name: MaterialDesignRaisedLightButton��5R   )   ��5S   )   �� *loginCommand+��5T   )   �� $ 
mainWindow��5U      5V      5W      5X      5Y      5Z      5[      5\      