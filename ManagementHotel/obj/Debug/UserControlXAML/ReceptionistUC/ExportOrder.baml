   M S B A M L   `   `   `  ����J  FManagementHotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ManagementHotel.UserControlXAML.ReceptionistUC.ManagementHotel.UserControlXAML.ReceptionistUC  5      @    :ManagementHotel.UserControlXAML.ReceptionistUC.ExportOrder   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ManagementHotel.UserControlXAML.ReceptionistUC     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      .��5      � 
�������.+�5   
   �   � RowDefinitions  5      �� 5      $
��auto �6    60   �� 5      6"   .+�5      � $��0��6   $��
20 10 0 10q�6    .+�5      � .+�5      �� $��Center=�6   $
��Left=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Choose room��5      $��18(�5      $
��Bold"�5      63   �� 5      $��Export��6   $��20 0 0 0q�5      61   5      5      � 5      $��1��6   .+�5      �� .+�5      � $��Center=�6    $��	0 10 0 20q�6=   .+�5       �� $��Hoa Don phong��6    $��Center=�5!       $��Center=�5"       $��20(�5#       $
��Bold"�5$       
���  ��5%   3   �� 5&      $	��204��6$   $��20(�5'   $   $
��Bold"�5(   $   
���  ��$��Center=�5*   $   $��Center=�5+   $   6C   5,      � 5-      $��20 0 0 0q�6    .+�5.      �� .+�5/      �� $��Thong tin khach hang��6$   $
��Bold"�50   $   68   � 51      $��0 5 0 0q�6(   .+�52   "   �� $��Khach hang: ��6(   $	��100��53   (   66   �� 54   "   $	��250��6,   $��10 0 0 0q�55   ,   
�������56   D   57      � 58      $��0 5 0 0q�6(   .+�59   "   �� $��So dien thoai: ��6(   $	��100��5:   (   66   �� 5;   "   $	��250��6,   $��10 0 0 0q�5<   ,   
�������5=   D   5>      � 5?      $��0 5 0 0q�6(   .+�5@   "   �� $��Gioi tinh: ��6(   $	��100��5A   (   66   �� 5B   "   $	��250��6,   $��10 0 0 0q�5C   ,   
�������5D   D   5E      � 5F      $��0 5 0 0q�6(   .+�5G   "   �� $��	Dia chi: ��6(   $	��100��5H   (   66   �� 5I   "   $	��250��6,   $��10 0 0 0q�5J   ,   
�������5K   D   5L      5M      �� 5N      $��40 0 0 0q�6%   .+�5O      �� $��Thong tin dich vu��6$   $
��Bold"�5P   $   68   � 5Q      $��0 5 0 0q�6(   .+�5R   "   �� $��	Check in:��6(   6>   �� 5S   "   $	��100��6,   $��5 0 0 0q�5T   ,   
�������5U   D   �� 5V   "   $��
Check out:��6(   $��20 0 0 0q�5W   (   6<   �� 5X   "   $	��100��6,   $��5 0 0 0q�5Y   ,   
�������5Z   D   5[      �� 5\      ��6'   �� *MyList+ �� SelectedItem 6F   �� *SelectedItem+ �� Mode$ TwoWay=� �� View 5]   "   �� 5^   &   .P�5_   *   �� $��DV��69    �� DisplayMemberBinding 6E   �� *MaKH+6m   �� 5`   *   $��SL��69    6E   �� *TenKH+6n   �� 5a   *   $	��Gia��69    6F   �� *GT+6l   5b   '   5d      � 5e      $��0 10 0 0q�6(   .+�5f   "   �� $��Tong tien: ��6(   
���  ��5g   ;   �� 5h   "   $��30 0 0 0q�6,   $	��150��5i   ,   
�������$
��Bold"�5k   ,   6@   5l      5m      5n      5o      5p      5q      5r      5s      