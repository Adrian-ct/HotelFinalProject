   M S B A M L   `   `   `  ����@  <Hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Hotel.View
Hotel.View  5   	   1clr-namespace:Hotel.ViewModelHotel.ViewModel  5   	       Hotel.View.ClientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Hotel.View     5   	   4
viewmodelsclr-namespace:Hotel.ViewModel     5   	     � Title$  ClientWindow��5
   	   $	��450��6   $	��800��6+    � 	Resources 5         booleanConverter��%   &	        �� 5   
   6'   5       � DataContext 5      %   Hotel.ViewModel.ClientViewModel  5   
   .��5      � .+�5   
   �� $��0,0,0,0q�6   .@�5      �� $	��100��6   $��30��6"   $��Available Rooms��6.   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      (  "System.Windows.Controls.DatePicker  $��25��6!   $	��100��6-   $	��Top=�69   $
��Left=�6Q   $��40, 20q�6l      SelectedDate 6|   �� *	CheckIn+  5      $��25��6!   $	��100��6-   $	��Top=�69   $
��Left=�6R   $��0, 20q�6m    6|   �� *
CheckOut+�� 5      
�������$��25��64   $	��100��6@   $	��Top=�6L   $
��Left=�6e   $��40, 20q�6�   $��Search��6�   ��6�   �� *SearchRooms+5      �� 5      -   5         ��Name$ listBox��5   �   $	��320��6   $��2q�6k   $��2��6   $��
40,10,40,0q�6�    J� 	AllowDrop . $��Visible=�6�   
������� �� SelectedIndex 6+   �� *Index+ �� SelectedItem 6K   �� *RoomNr+��6
  �� *Rooms+��5       �� 5!      .R�5"   "   � 	 � ColumnDefinitions	 5#   &   �� 5$   *   6=   �� 5%   *   6=   .+�5'   &   �� $ 
Horizontal=�61   $��0��6J   .+�5)   *   �� $��3q�60   $	��200��6;   $	��100��6G   ��6T   �� *image+�� 5+   *   $��3q�64   $��Tip camera:��6?   $��20(�6R   �� 5,   *   $��3q�64   $��20(�6U   ��6?   �� *type+6U   5/   '   � 50   &   $��1��6+   $��220, 0, 0, 0q�6<   .+�51   *   �� $ Vertical=�65   .+�52   .   �� $ 
Horizontal=�69   $��1��6R   $	��Top=�6_   .+�53   2   �� $��Pret:��6=   $��20(�6J   6Z   �� 54   2   $��
0, 0, 30,0q�6<   $��20(�6h   ��6Q   �� *price+6x   56   /   �� 57   .   $��Rezerva��65   $��0, 50, 0, 0q�6G   $��4q�6\   ���#ffd77b��58   )   �� *DataContext.BookCommand+
 �� RelativeSource
 ��  �� AncestorType$ ListBoxL�y�59   (   �� *%#DataContext.IsButtonReservedVisible+
 �� $ ListBoxL� �� 	Converter# [  �� 5=   .   $��Administreaza��65   $��0, 30, 0, 0q�6M   $��4q�6b   ���#ffd77b��5>   )   �� *DataContext.AdminCommand+
 �� $ ListBoxL�y�5?   )   �� *" DataContext.IsButtonAdminVisible+
 �� $ ListBoxL�# [  5B   +   5D   '   5F   #   5I      5K      5M      5Q      �� 5R      $	��100��6   $��30��6"   $��Offers��6.   5T      5U      5X      5Y      