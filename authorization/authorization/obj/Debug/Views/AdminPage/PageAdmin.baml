   M S B A M L   `   `   `  ����H  Dauthorization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:authorization.Views.AdminPageauthorization.Views.AdminPage  5      -    'authorization.Views.AdminPage.PageAdmin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:authorization.Views.AdminPage     5      -   5          N� Title$  	PageAdmin��5	      .��5      � .+�5   
   �� .+�5      �� $��/Image/FON.jpg��6   6.   5       � 5   
   -   5          �Name$ FrameEditPage��5        � NavigationUIVisibility$ Hidden=�6'   6I   � 5   
    � RowDefinitions 5      �� 5      $��50 �6    6.   �� 5      6"   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ ButtonGoBack��5   s   $��
Назад��6   $	��100��6*   $��30��66   $��10q�6B   
�������
���  ��5      �� 5"      -   5        $ 	ButtonAdd��5#   _   $	��100��5"      $��30��6%   
���   �
�������$��10q�5#   @   $��Добавить��6L   5$      �� 5'      -   5        $ 
ButtonEdit��5'   C   $	��130��6   $��30��6%   $��5 10 0 5q�61   
���   �$ ��Редактировать��6k   
�������5(      �� 5+      -   5        $ ButtonDelete��5+   C   $	��100��6   $��30��6%   
���  ��$��Удалить��6Y   
�������$��30 10 10 10q�6~   5,      �� 5.      .+�5/      �� -   5        $	��150��5/      $��30��6)   
�������
���  ��$(��"Удалить все строки��6Z   $��0 10 0 0q�6w   6�   50      �� 53      $��Center=�6   $ 
Horizontal=�6:   .+�54      �� $��Поиск:��6    $��70��6.   $��20(�69   $��
150 15 0 0q�6G   6]   �� 55      -   5         ��Name$ textboxSearch��55   �   $	��200��6   $��30��6*   $��0,15,0,5q�66   
�������
���   �$��15(�6s   6�   �� 58      .+�59      �� $��/Image/poisk.jpg��6    $��40��6:   $��0 5 0 0q�6F   5:      5;      5=      5@      &   System.Windows.Controls.DataGrid  5B      -	   5          Name$ DataGridTablica��5B   $   $��1��6      
IsReadOnly . 	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6O   
   AutoGenerateColumns
 .     Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header$# Номер работника��5H         Width$	 137 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Employee.Position+5I        5L      $ ФИО Работника��5M      $	 126 6V    60   �� *Employee.FullName+5N        5Q      $ Должность��5R      $ 98 6R    6,   �� *Employee.Position+5S        5Z      $ Номер работы��5[      $	 140 6`    6/   �� *CompletingOfTheWork.NomerJob+5\        5^      $# Название работы��5_      $	 140 6c    62   �� *CompletingOfTheWork.NameWork+5`        5c      $ Трудоемкость��5d      $	 115 6e    6/   �� *#!CompletingOfTheWork.Laboriousness+5e        5g      $# Дата завершения��5h      $	 145 6�    62   �� *$"CompletingOfTheWork.DataOfComplite+ �� StringFormat$ {0:dd MMMM yyyy}��5i        5l      $: 4Планируемая дата завершения��5m      $	 220 6�    6:   �� *$"CompletingOfTheWork.PlannedEndDate+$ {0:dd MMMM yyyy}��5n        5p      $# Завершенность(%)��5q      $	 150 6e    63   �� *CompletingOfTheWork.Readiness+5r      5w      5}      5~      5      