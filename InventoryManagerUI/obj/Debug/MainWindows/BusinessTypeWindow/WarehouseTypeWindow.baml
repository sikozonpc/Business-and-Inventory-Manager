   M S B A M L   `   `   `  ����M  IInventoryManagerUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:InventoryManagerUI.MainWindows.BusinessTypeWindow1InventoryManagerUI.MainWindows.BusinessTypeWindow  5   	   K    EInventoryManagerUI.MainWindows.BusinessTypeWindow.WarehouseTypeWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Qlocal?clr-namespace:InventoryManagerUI.MainWindows.BusinessTypeWindow     5   	     � Title$  	Warehouse��5   	   $	��300��6   $	��500��6(   ���#2e3030
�������$��Segoe UI Light)�5	   	   $��20(�6%   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ companyName��5      $��0��6)   $��0��69   $��Company Name��6F    �� Padding$ 20,20q�6[   �� 5   
   -   5         ��Name$ companyNameTextBox��5      $��0��6.   $��40��6;   $	��200��6G   $��251,10,0,17q�6S   $��3��6h   �� 5    
   -   5        $ companyBudget��5       $��Company Current Budget��6+   $��0��6I   $��1��6Y   $ 20,20q�6f   �� 5!   
   -   5        $ companyBudgetTextBox��5!      $��1��60   $��1��6@   $	��146��5"      $��40��6&   $
��Left=�62   $��	0,14,0,13q�6M   �� 5#   
   -   5         ��Name$ currencyComboBox��5#      
�������$��2��5$      $��1��6'   $��Right=�64   $��40��5%      $��50��6#   5&      �� 5)   
   -   5        $ companySpendings��5)      $��Current Spendings��6.   $��0��6G   $��2��6W   $ 20,20q�6d   �� 5*   
   -   5        $# companyCurrentSpendingTextBox��5*      $��1��69   $��2��6I   $	��146��5+      $��40��6&   $
��Left=�62   $��	0,13,0,14q�6M   �� 5/   
   -   5         ��Name$ StartCompanyButton��5/      $��0��6-   $��5��6=   
������ 
��� ���$��1q�50   F   $	��200��6[   $��40��6g   .��53      ��  �� Orientation$ 
Horizontal=�6   .+�54      �� 
Complete6&   55      56      59      5:      