   M S B A M L   `   `   `  ����M  IInventoryManagerUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:InventoryManagerUI.MainWindowsInventoryManagerUI.MainWindows  5   	   -    'InventoryManagerUI.MainWindows.Activity   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:InventoryManagerUI.MainWindows     5   	     � Title$  Activity��5   	   $	��450��6   $	��900��6'   ���#2e3030
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
��auto �6   �� 5      $��* �6   �� 5      $��10 �6   .+�5   
   �� $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5       �� -   5         ��Name$ 
HomeButton��5       $��2��5!      $��3��6   $��25(�6*   
������ ���#F29705$��1q�5"   ?   $
��Left=�5#      $��10q�6,    J� Effect 5%      3  -System.Windows.Media.Effects.DropShadowEffect  5&      .��5)      �� $ 
Horizontal=�6   .+�5*      �� Home6&   5+      5,      �� 5-      -   5        $ SpendingButton��5-      $��2��5.      $��3��6   $��25(�6*   
������ ���#ffffff$��1q�5/   ?   $
��Left=�50      $��10q�6,    52        53      .��56      �� $ 
Horizontal=�6   .+�57      �� 
Spending6*   58      59      �� 5:      -   5        $ BillsButton��5:      $��2��5;      $��3��6   $��25(�6*   
������ ���#ffffff$��1q�5<   ?   $
��Left=�5=      $��10q�6,    5?        5@      .��5C      �� $ 
Horizontal=�6   .+�5D      �� Bills6'   5E      5F      �� 5G      -   5        $ PlanningButton��5G      $��2��5H      $��3��6   $��25(�6*   
������ ���#ffffff$��1q�5I   ?   $
��Left=�5J      $��10q�6,    5L        5M      .��5P      �� $ 
Horizontal=�6   .+�5Q      �� 
Planning6*   5R      5S      �� 5T      -   5        $ InvestingButton��5T      $��2��5U      $��3��6   $��25(�6*   
������ ���#ffffff$��1q�5V   ?   $
��Left=�5W      $��10q�6,    5Y        5Z      .��5]      �� $ 
Horizontal=�6   .+�5^      �� 	Investing6+   5_      5`      5a       � 5c   
   -   5          �Name$ navigationFrame��5c      $��1��6)   $��3��69   $��7��6F     � NavigationUIVisibility$ Hidden=�5d      5f      5h      5i      