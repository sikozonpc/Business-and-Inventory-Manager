   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      M IInventoryManagerUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:InventoryManagerUI.MainWindows.ActivityPages,InventoryManagerUI.MainWindows.ActivityPages 5      Q-clr-namespace:InventoryManagerUI.UserControlsInventoryManagerUI.UserControls 5      7   1InventoryManagerUI.MainWindows.ActivityPages.Home   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      7System&clr-namespace:System;assembly=mscorlib    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Llocal:clr-namespace:InventoryManagerUI.MainWindows.ActivityPages     5      Fusercontrols-clr-namespace:InventoryManagerUI.UserControls     5        N� Title$
  Home��5       N� FontSize$ 15(�6    N� 
FontFamily$ Segoe UI Light)�6"    N� 
Foreground
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
    � ���#2e3040  � NavigationUIVisibility$ Hidden=�6%   $��1��5      $��1��6    $��10��6-   $��5��6B   5      �� 5    
   $��Where Your Money Goes :��6   
��� ���$��1��5!      $��1��6$    �� Padding$ 20q�61   �� 5$   
   $��1��6   $��2��6&   $��50,-10q�63    �� Orientation$ 
Horizontal=�5%      .+�5'      �� $ Vertical=�6   .+�5(      �� $��Total Spending��6   $ 20q�62   
�������$��Segoe UI Symbol)�6R   $��18(�6o   $
��Bold"�6}   �� 5)      $ 
Horizontal=�6   .+�5*      �� -   5        	 ��Name$	 totalmoneySpentValue��5*       $��10,000��6>   $
��40,0q�6L   $��20(�6Z   $��Segoe UI Symbol)�6h   $
��Bold"�6�   5+      �� 5-      -   5        
 ��Name$
 MoneySpentHistory��5-      
������ 
����� �$��1q�5.   C   $
��Left=�5/      $
��0,10q�6,   $��SemiCondensed&�6:   &   System.Windows.Media.TextOptions   TextHintingMode$ Animated=�50   1   .��52      �� $ 
Horizontal=�6!   .+�53      �� Examine your spending6;   54      55      57      �� 58      $ Vertical=�6   .+�59      �� $��Last Month Spending��6   $ 20q�67   
�������$��Segoe UI Symbol)�6W   $��18(�6t   $
��Bold"�6�   �� 5:      $ 
Horizontal=�6   .+�5;      �� -   5        $	 lastMonthMoneySpent��5;       $��10,000��6=   $
��40,0q�6K   $��20(�6Y   $��Segoe UI Symbol)�6g   $
��Bold"�6�   5<      5=      5?      �� 5@   
   $��Budget��6   $��
30,10,49,0q�6"   $��1��66   $��3��6F   $ 20q�6S   �� 5B   
   $��1��6   $��3��6%   $��20q�62   .+�5C      �� $��Current��6   $��90,-24q�6'   
��� ���67   �� 5D      -   5        $	 currentSpentValue��5D      $��150,-24q�63   $��( 200 € )��6D   
�������6U   �� 5F      $��Total��6   $��230,-24q�6%   
��� ���66   �� 5G      -   5        $	 budgetValue��5G      $��270,-24q�6-   $��( 600 € )��6>   
�������6O   �� 5I      $	��400��6   $��40��6!   
�������$��1q�5J   (   ._�5K      �� -   5         ��Name$ progressBudgetBar��5K      $	��400��64   $��40��6@   
�������$��0q�5L   -   $
��Left=�6A   $��Center=�6\   $��-1q�6w   ��5M      �� 5N       �� 
StartPoint$	 0,0&�6.    �� EndPoint$	 1,1&�6?   .��5O      �  � Color$ White��6+    � Offset$	 0.0Q�69   � 5P      $ 
DarkOrange��6+   $	 0.0Q�6>   5R      5T      5U      5W      /  )InventoryManagerUI.UserControls.YearGraph  5Y   
   -   5          Name$ 	yearGraph��5Y   !   $��1��64   $��1��6D   $��4��6Q   $��557,20,-6,0q�6e   $��3��6z   6�   5[      5]      