   M S B A M L   `   `   `  ����E  ADEMLASTMAY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DEMLASTMAY
DEMLASTMAY  5          DEMLASTMAY.OrderPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DEMLASTMAY     5        N� Title$  	OrderPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��1* �6   6*   �� 5      $��70 �6   6*   .+�5   
   �� $'��!Оформление заказа��6   $��Center=�6-   $��25(�6J   $��Comic Sans MS)�6X   ���#498c516�   � 5   
   $��1��6    � Orientation$ Vertical=�6!   .+�5      ��  �� Orientation$ Vertical=�6   $
��Left=�60   $��0 0 0 20q�6K   .+�5      �� $��Номер заказа��6   $��20��60   6>   �� 5      -   5         ��Name$ numberOrder��5      $	��200��6/   $��30��6;   $
��Left=�6G   6d   5      �� 5      $ Vertical=�6   $
��Left=�60   $��0 0 0 20q�6K   .+�5      �� $��Клиент��6   $��20��6*   68   �� 5      $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ comboClient��5      $	��200��64    �� 
IsEditable .  �� StaysOpenOnEdit . $��30��6j   $
��Left=�6v    �� DisplayMemberPath$ 
ClientCode��6�   6�   �� 5      -   5        $��createClient��5   U   $��Создать��6   $��10 0 0 0q�6/   $��	10 0 10 0q�6A   6�   5      5      �� 5      $ Vertical=�6   $
��Left=�60   $��0 0 0 20q�6K   .+�5       �� $��Услуги��6   $��20��6*   68   �� 5!      -   5        $ comboService��5!      $	��200��61   $��30��6=    .  . $
��Left=�6r   $ ServiceName��6�   6�   5"      �� 5#      -   5        $��BtnOrder��5#   ?   $��Оформить��6   $	��100��6O   $��30��6[   ���#498c51���#fff$��Center=�6�   $��5q�6�   6�   5$      �� 5&   
   -   5        $��BtnBackOrder��5&   I   $��2��6   $��
Назад��6   $	��100��6]   $��30��6i   ���#498c51���#fff$��Right=�6�   $��5q�6�   6�   5'      5(      