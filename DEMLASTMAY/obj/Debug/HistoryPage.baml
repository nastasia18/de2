   M S B A M L   `   `   `  ����E  ADEMLASTMAY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DEMLASTMAY
DEMLASTMAY  5          DEMLASTMAY.HistoryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DEMLASTMAY     5      -   5          N� Title$  HistoryPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��70 �6   6*   �� 5      $��1* �6   6*   �� 5      $��70 �6   6*   .+�5   
   �� $��История входа��6   $��Center=�6)   $��25(�6F   $��Comic Sans MS)�6T   ���#498c516�   � 5   
    � Orientation$ 
Horizontal=�6   $��1��6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $#��Выберите логин: ��6   $	��175��64    �� TextAlignment$ Center=�6@   6Y   �� 5      -   5        $��ComboFilter��5   '   $	��224��6   6l   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Дата��6   $	��175��6(   $ Center=�64   6M   �� 5      -   5        $��DateSort��5   '   $	��224��6   .@�5      �� Сначала старые60   �� 5      Сначала новые6/   5      5      5      &   System.Windows.Controls.DataGrid  5    
   -   5        $��GridHistory��5          AutoGenerateColumns .     
IsReadOnly . $��2��6T      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6%   	   Header$)	 #Логин пользователя��60   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6L   �� *EmployeeLogin+6p     5#      $ 1* 6%   $	 Статус входа��60   
 6F   �� *LoginStatus+6h     5$      $ 1* 6%   $	 Дата входа��60   
 6D   �� *EmployeeDataLogin+6l   5&      �� 5'   
   -   5        $��BtnBackHistory��5'   K   $��3��6   $��
Назад��6   $	��100��6a   $��30��6m   ���#498c51���#fff$��Right=�6�   $��5q�6�   6�   5(      5)      