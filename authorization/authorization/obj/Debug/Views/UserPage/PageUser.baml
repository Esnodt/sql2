   M S B A M L   `   `   `  ����H  Dauthorization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:authorization.Views.UserPageauthorization.Views.UserPage  5      +    %authorization.Views.UserPage.PageUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:authorization.Views.UserPage     5        N� Title$  PageUser��5	      .��5      � .+�5   
   �� .+�5      �� $��/Image/FON.jpg��6   6.   5      � 5   
    � RowDefinitions 5      �� 5      $��50 �6    6/   �� 5      6/   .+�5      �� .+�5      �� $
��Left=�6   $��	20 10 0 0q�68   .+�5       �� -   5        $��25��5       $	��100��6)   
�������
���   �$��
Назад��6\   6�   5"      �� 5$       �� Orientation$ 
Horizontal=�6   $��Center=�5'      .+�5(      �� $��Поиск:��6    $��70��6.   $��20(�69   $��600 -20 0 0q�6G   5)      �� 5,      $	��200��6   $��30��6*   $��	0 -20 0 0q�66   
�������
���   �$��15(�6t   6�   �� 5.      .+�5/      �� $��/Image/poisk.jpg��6    $��40��6:   $��	0 -23 0 0q�6F   50      51      53      55      &   System.Windows.Controls.DataGrid  5?      -   5          Name$ DataGridTablica1��5?   $   $��1��6      
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6P      AutoGenerateColumns .     Columns 5A      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$# Название работы��5E      	   Width$		 140 6c   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� *CompletingOfTheWork.NameWork+5F        5H      $ ФИО Работника��5I      $		 126 6V   
 60   �� *Employee.FullName+5J        5L      $ Трудоемкость��5M      $		 115 6e   
 6/   �� *#!CompletingOfTheWork.Laboriousness+5N        5P      $: 4Планируемая дата завершения��5Q      $		 220 6�   
 6:   �� *$"CompletingOfTheWork.PlannedEndDate+ �� StringFormat$ {0:dd MMMM yyyy}��5R        5U      $# Завершенность(%)��5V      $		 150 6e   
 63   �� *CompletingOfTheWork.Readiness+5W        5Y      $# Дата завершения��5Z      $		 200 6�   
 62   �� *$"CompletingOfTheWork.DataOfComplite+$ {0:dd MMMM yyyy}��5[      5_      5h      5i      5j      