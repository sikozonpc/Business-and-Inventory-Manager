   M S B A M L   `   `   `  ����M  IInventoryManagerUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:InventoryManagerUIInventoryManagerUI  5   	   .    (InventoryManagerUI.SubWindows.AddProduct   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:InventoryManagerUI     5   	     � Title$  Add Product��5   	   $	��400��6   $	��500��6*   ���#2e3030
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
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $��* �6   �� 5"      $��10 �6   .+�5%   
   �� $��Product Name��6   $��1��6(   $��1��68   �� 5&   
   -   5         ��Name$ productNameTextBox��5&      $��2��6.   $��1��6>   $	��200��5'      �� 5)   
   $��Product Type��6   $��1��6(   $��2��68   �� 5*   
   -   5        $ productTypeTextBox��5*      $	��200��6.   $��2��6:   $��2��6J   �� 5,   
   $��Quantity��6   $��1��6$   $��3��64   �� 5-   
   -   5        $ productQuantityTextBox��5-      $	��100��62   $��2��6>   $��3��6N   $
��Left=�6�   �� 5/   
   $��Price��6   $��1��6!   $��4��61   �� 50   
   -   5        $ productPriceTextBox��50      $	��100��6/   $��2��6;   $��4��6K   $
��Left=�6Y   �� 52   
   $��Provider Name��6   $��1��6)   $��5��69   �� 53   
   -   5        $  productProviderNameTextBox��53      $	��200��66   $��2��6B   $��5��6R   �� 55   
   $��Receipt Date��6   $��1��6(   $��6��68   �� 56   
   -   5        $ productReceiptDateTextBox��56      $	��200��65   $��2��6A   $��6��6Q   �� 58   
   $��Location��6   $��1��6$   $��7��64   �� 59   
   -   5        $ productLocationTextBox��59      $	��200��62   $��2��6>   $��7��6N   �� 5=   
   -   5         ��Name$ saveProductButton��5=      $��1��5>      $��8��6   $��15q�6+   
������ 
�������$��0q�5?   D    � Cursor$
 Hand��5@      $
��Left=�6    J� Effect 5B      3  -System.Windows.Media.Effects.DropShadowEffect  5C      .��5F      ��  �� Orientation$ 
Horizontal=�6   .+�5G      �� $��/Images/purchase.png��6   $
��None=�66   �� 5H      $��Save Product��6   5I      5J      �� 5M   
   -	   5         ��Name$ messageNotifier��5M      $��2��6-   $��1��6A   $��9��6Q   5O      5P      