   M S B A M L   `   `   `  ����@  <Hotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Hotel.View
Hotel.View  5   	   1clr-namespace:Hotel.ViewModelHotel.ViewModel  5   
       Hotel.View.GuestWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Hotel.View     5   	   3	ViewModelclr-namespace:Hotel.ViewModel     5   
     � Title$  GuestWindow��5	   	   $	��450��6   $	��800��6*    � 	Resources 5
         listTemplate��%�   &	        �� 5   
   .R�5      �� .+�5      �� ��6   �� *
Username+�� 5      ��6   �� *
First_name+�� 5      ��6   �� *	Last_name+5      5      5      .��5      � .+�5   
   �� -   5         ��Name$ context��5      $	��400��6#   $��10q�6/   #��[  5   
   ��5   
   �� *Guests+ � DataContext 5      $  Hotel.ViewModel.GuestViewModel  5      5      5       5!      