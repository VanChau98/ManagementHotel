   M S B A M L   `   `   `  ����J  FManagementHotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ManagementHotel.ViewsManagementHotel.Views  5   	   Q-clr-namespace:ManagementHotel.UserControlXAMLManagementHotel.UserControlXAML  5
   	   g8clr-namespace:ManagementHotel.UserControlXAML.EmployerUC*ManagementHotel.UserControlXAML.EmployerUC  5   	   *    $ManagementHotel.Views.EmployerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ManagementHotel.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   >
controlBar-clr-namespace:ManagementHotel.UserControlXAML  5
   	   I
employerUC8clr-namespace:ManagementHotel.UserControlXAML.EmployerUC  5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ EmployerWindow��5   	   $	��650��6    $
��1000��6-   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      0   *ManagementHotel.UserControlXAML.ControlBar  6&   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      .+�5      � $��0��6   .+�5      �� 
����+��.+�5      �� $��Luxury Hotel��6   
��� ���$��28(�5!       $
��Bold"�5"       64   �� 5#      $��Employee Manager��6   $
��Bold"�5$       $��20(�5%       $��Center=�5&       
�������5'   9   �� 5)      -   5         ��Name$ ListViewMenu��5)      .@�5*      �� $��0,10,0,0q�6'   .��5+      ��  �� Orientation$ 
Horizontal=�6)   .+�5,   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountEdit=�6:   
���   �$��40��5.   :   $��35��5/   :   $��Center=�50   :   �� 51   "   $
��Wrap=�6,   $��Employee��52   ,   
���   � �� TextAlignment$ Center=�54   ,   $��Center=�55   ,   $��Center=�56   ,   $��10q�57   ,   $��20(�68   6I   58      59      �� 5:      $��0,5,0,0q�6(   .��5;      �� $ 
Horizontal=�6)   .+�5<   "     $ Ballot=�6:   
���   �$��40��5>   :   $��35��5?   :   $��Center=�5@   :   �� 5A   "   $
��Wrap=�6,   $��Account ��5B   ,   
���   �$ Center=�5D   ,   $��Center=�5E   ,   $��Center=�5F   ,   $��10q�5G   ,   $��20(�68   6I   5H      5I      5K      5M      5N      � 5O      $��1��6   .+�5P      9   3ManagementHotel.UserControlXAML.EmployerUC.Employee  -   5        	  Name$	 employee��5P   &   6:   8   2ManagementHotel.UserControlXAML.EmployerUC.Account  5Q      -   5        
  Name$
 account��5Q   %   $y�Hidden=�66   6L   5R      5S      5T      5U      