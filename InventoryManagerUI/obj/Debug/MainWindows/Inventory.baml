   M S B A M L   `   `   `  ����M  IInventoryManagerUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:InventoryManagerUI.MainWindowsInventoryManagerUI.MainWindows  5   	   .    (InventoryManagerUI.MainWindows.Inventory   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:InventoryManagerUI.MainWindows     5   	     � Title$  	Inventory��5   	   $	��450��6   $	��900��6(   ���#2e3030
�������$��Segoe UI Light)�5	   	   $��25(�6%   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5       $��10 �6   .+�5#   
   �� $��	Inventory��6   $��1��6%   $��1��65   $��40(�5$       �� Padding$ 10q�6"   
��� ���6/   �� 5&   
   $��Products List��6   $��1��6)   $��2��69   $ 10q�5'      �� 5)   
   $��1��6   $��3��6'   $��15(�64   $��5��6B   $	��200��5*      $	��600��6$   ���#2e3030.��5+      &   System.Windows.Controls.DataGrid  -   5        $��productsListDataGrid��5+         AutoGenerateColumns .    
IsReadOnly . ���#2e30305.      5/      �� 51   
   -   5         ��Name$ addProductButton��51      $��2��52      $��3��6   $��20(�6*   
������ 
�������$��0q�53   D    � Cursor$
 Hand��54      $
��Left=�6    J� Effect 56      3  -System.Windows.Media.Effects.DropShadowEffect  57      .��5:      �� 	 �� Orientation$	 
Horizontal=�6   .+�5;      �� $��/Images/Selectors/add.png��6   $
��None=�6;   �� 5<      Add6!   5=      5>      �� 5@   
   -   5        $ removeProductButton��5@      $��2��5A      $��4��6   $��20(�6*   
������ 
�������$��0q�5B   D   $
 Hand��5C      $
��Left=�6    5E        5F      .��5I      �� $	 
Horizontal=�6   .+�5J      �� $"��/Images/Selectors/remove.png��6   $
��None=�6>   �� 5K      Remove6$   5L      5M      �� 5O   
   -   5        $ refrehProductButton��5O      $��2��5P      $��5��6   $��20(�6*   
������ 
�������$��0q�5Q   D   $
 Hand��5R      $
��Left=�6    5T        5U      .��5X      �� $	 
Horizontal=�6   .+�5Y      �� $#��/Images/Selectors/refresh.png��6   $
��None=�6?   �� 5Z      	Refresh6%   5[      5\      5^      5_      