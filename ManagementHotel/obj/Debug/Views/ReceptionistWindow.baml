   M S B A M L   `   `   `  ����J  FManagementHotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ManagementHotel.ViewsManagementHotel.Views  5   	   Q-clr-namespace:ManagementHotel.UserControlXAMLManagementHotel.UserControlXAML  5
   	   o<clr-namespace:ManagementHotel.UserControlXAML.ReceptionistUC.ManagementHotel.UserControlXAML.ReceptionistUC  5   	   .    (ManagementHotel.Views.ReceptionistWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ManagementHotel.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   >
controlBar-clr-namespace:ManagementHotel.UserControlXAML  5
   	   QreceptionistUC<clr-namespace:ManagementHotel.UserControlXAML.ReceptionistUC  5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�5   	    � Title$ ReceptionistWindow��5   	   $	��600��6$   $
��1000��61   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      0   *ManagementHotel.UserControlXAML.ControlBar  6&   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   62   �� 5      6%   .+�5      � .+�5      � $��0��6   .+�5      ��  �� Orientation$ Vertical=�6!   
����+��.+�5       �� $��Luxury Hotel��6    
��� ���$��28(�5"       $
��Bold"�5#       64   �� 5$      $��Receptionist��6    
�������$
��Bold"�5&       $��20(�5'       $��Center=�5(       6?   �� 5)      -   5         ��Name$ ReceptionistMenu��5)   #   .@�5*      �� $��0 10 0 0q�6+   .��5+   "   �  � Orientation$ 
Horizontal=�6,   .+�5,   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
TableLarge=�6>   $��40��5-   >   $��40��5.   >   
�������5/   W   �� 50   &   $��Booking Room��6,   $��Bottom=�51   ,   
�������$��15(�53   ,   $
��Bold"�54   ,   6@   55   #   56      �� 57      $��0 10 0 0q�6+   .��58   "   �� $ 
Horizontal=�6-   .+�59   &     $ DatabaseSearch=�6>   $��40��5:   >   $��40��5;   >   
�������5<   W   �� 5=   &   $
��Room��6,   $��15(�5>   ,   
�������$��Bottom=�5@   ,   $
��Bold"�5A   ,   6@   5B   #   5C      �� 5D      $��0 10 0 0q�6+   .��5E   "   �� $ 
Horizontal=�6-   .+�5F   &     $ 	SearchWeb=�6>   $��40��5G   >   $��40��5H   >   
�������5I   W   �� 5J   &   $��Service��6,   $��15(�5K   ,   
�������$��Bottom=�5M   ,   $
��Bold"�6G   6[   5N   #   5O      �� 5P      $��0 10 0 0q�6+   .��5Q   "   �� $ 
Horizontal=�6-   .+�5R   &     $ Ballot=�6>   $��40��5S   >   $��40��5T   >   
�������5U   W   �� 5V   &   $��Export Order��6,   $��15(�5W   ,   
�������$��Bottom=�5Y   ,   $
��Bold"�6G   6[   5Z   #   5[      5\      5]      5^      5_      � 5`      $��1��6   .+�5a      <   6ManagementHotel.UserControlXAML.ReceptionistUC.Booking  -   5        	  Name$	 booking��5a   )   6<   9   3ManagementHotel.UserControlXAML.ReceptionistUC.Room  5b      -   5        
  Name$

 room��5b   &   $y�Hidden=�64   6J   <   6ManagementHotel.UserControlXAML.ReceptionistUC.Service  5c      -   5          Name$ service��5c   )   $y�Hidden=�6:   6P   @   :ManagementHotel.UserControlXAML.ReceptionistUC.ExportOrder  5d      -   5          Name$ exportOrder��5d   -   $y�Hidden=�6B   6X   5e      5f      5g      5h      