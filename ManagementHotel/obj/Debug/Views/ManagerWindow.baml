   M S B A M L   `   `   `  ����J  FManagementHotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ManagementHotel.ViewsManagementHotel.Views  5   	   Q-clr-namespace:ManagementHotel.UserControlXAMLManagementHotel.UserControlXAML  5
   	   e7clr-namespace:ManagementHotel.UserControlXAML.ManagerUC)ManagementHotel.UserControlXAML.ManagerUC  5   	   )    #ManagementHotel.Views.ManagerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ManagementHotel.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
   >
controlBar-clr-namespace:ManagementHotel.UserControlXAML  5
   	   G	managerUC7clr-namespace:ManagementHotel.UserControlXAML.ManagerUC  5   	     � Title$  ManagerWindow��5   	   $	��600��6   $
��1000��6,    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      0   *ManagementHotel.UserControlXAML.ControlBar  6&   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      .+�5      � $��0��6   .+�5      �� 
����+��.+�5      �� $��Luxury Hotel��6   
��� ���$��28(�5!       $
��Bold"�5"       64   �� 5#      $��Manager��6   $
��Bold"�5$       $��20(�5%       $��Center=�5&       
�������5'   9   �� 5)      -   5         ��Name$ ListViewMenu��5)      .@�5*      �� $��0,10,0,0q�6'   .��5+      ��  �� Orientation$ 
Horizontal=�6)   .+�5,   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountEdit=�6:   
���   �$��40��5.   :   $��35��5/   :   $��Center=�50   :   �� 51   "   $
��Wrap=�6,   $��Customer��52   ,   
���   � �� TextAlignment$ Center=�54   ,   $��Center=�55   ,   $��Center=�56   ,   $��10q�57   ,   $��20(�68   6I   58      59      �� 5:      $��0,5,0,0q�6(   .��5;      �� $ 
Horizontal=�6)   .+�5<   "     $ Ballot=�6:   
���   �$��40��5>   :   $��35��5?   :   $��Center=�5@   :   �� 5A   "   $
��Wrap=�6,   $��Room ��5B   ,   
���   �$ Center=�5D   ,   $��Center=�5E   ,   $��Center=�5F   ,   $��10q�5G   ,   $��20(�68   6I   5H      5I      �� 5J      $��0,5,0,0q�6(   .��5K      �� $ 
Horizontal=�6)   .+�5L   "     $ AccountCacheOutline=�6:   
���   �$��40��5N   :   $��35��5O   :   $��Center=�5P   :   �� 5Q   "   $
��Wrap=�6,   $��Service ��5R   ,   
���   �$ Center=�5T   ,   $��Center=�5U   ,   $��Center=�5V   ,   $��10q�5W   ,   $��20(�68   6I   5X      5Y      �� 5Z      $��0,5,0,0q�6(   .��5[      �� $ 
Horizontal=�6)   .+�5\   "     $ Ballot=�6:   
���   �$��40��5^   :   $��35��5_   :   $��Center=�5`   :   �� 5a   "   $
��Wrap=�6,   $��
Statistics��5b   ,   
���   �$ Center=�5d   ,   $��Center=�5e   ,   $��Center=�5f   ,   $��10 0 0 0q�5g   ,   $��20(�6>   6O   5h      5i      5j      5l      5m      � 5n      $��1��6   .+�5o      8   2ManagementHotel.UserControlXAML.ManagerUC.Customer  -   5        	  Name$	 customer��5o   %   69   4   .ManagementHotel.UserControlXAML.ManagerUC.Room  5p      -   5        
  Name$

 room��5p   !   $y�Hidden=�6/   6E   7   1ManagementHotel.UserControlXAML.ManagerUC.Service  5q      -   5          Name$ service��5q   $   $y�Hidden=�65   6K   :   4ManagementHotel.UserControlXAML.ManagerUC.Statistics  5r      -   5          Name$ 
statistics��5r   '   $y�Hidden=�6;   6Q   5s      5t      5u      5v      