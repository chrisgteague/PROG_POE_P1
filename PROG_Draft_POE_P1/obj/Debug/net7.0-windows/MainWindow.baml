   M S B A M L   `   `   `  ����L  HPROG_Draft_POE_P1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PROG_Draft_POE_P1PROG_Draft_POE_P1  5   	   "    PROG_Draft_POE_P1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PROG_Draft_POE_P1     5   	     � Title$  
MainWindow��5   	   $	��434��6   $	��527��6)   .��5	      � .+�5
   
   �� .@�5      �� $��Semester Start��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5         ��Name$ tbNumberOfWeeks��5      $
��Left=�67   $��	139,0,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $��Center=�6�   $	��120��6�   �� 5      $��Number of Weeks��6   $
��Left=�66   $��34,0,0,0q�6Q   $��Center=�6c    J� RenderTransformOrigin$ 0.513,0.502&�6~   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpSemesterStartDate��5   !   $
��Left=�6>   $��281,186,0,0q�6Y   $	��Top=�6n   $	��120��6�   �� 5      -   5         ��Name$ btnAddSemester��5      $��Add Semester��65   $
��Left=�6L   $��139,221,0,0q�6g   $	��Top=�6|   $��29��6�   $��80��6�   6�   5      5      �� 5      $��
Add Module��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5        $ tbModuleName��5      $
��Left=�64   $��
120,43,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6�   $	��120��6�   �� 5      $��Module Name��6   $
��Left=�62   $��	34,39,0,0q�6M   $	��Top=�6`   $ 0.513,0.502&�6x   �� 5      -   5        $ tbModuleCode��5      $
��Left=�64   $��
120,74,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6�   $	��120��6�   �� 5      $��Module Code��6   $
��Left=�62   $��	38,70,0,0q�6M   $	��Top=�6`   $ 0.513,0.502&�6x   �� 5      -   5        $ tbNumberOfCredits��5      $
��Left=�69   $��120,105,0,0q�6T   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��120��6�   �� 5      $��Number Of Credits��6   $
��Left=�68   $��
10,101,0,0q�6S   $	��Top=�6g   $ 0.513,0.502&�6   �� 5      -   5        $ tbClassHours��5      $
��Left=�64   $��120,136,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5      $��Class Hours��6   $
��Left=�62   $��
48,132,0,0q�6M   $	��Top=�6a   $ 0.513,0.502&�6y   �� 5      -   5        $ btnAddModule��5      $��
Add Module��63   $
��Left=�6H   $��140,198,0,0q�6c   $	��Top=�6x   $��29��6�   $��80��6�   6�   5      5      �� 5!      $��Record Self Study Hours��6   .��5"      � ���	#FFE5E5E5.+�5#      �� -	   5        $ btnAddSelfStudyHours��5#      $��Add Self Study Hours��6;   $
��Left=�6Z   $��137,214,0,0q�6u   $	��Top=�6�   $��29��6�   $	��124��6�   6�   �� 5$      -
   5        $ tbNumberOfSelfStudyHours��5$      $
��Left=�6@   $��	139,0,0,0q�6[   $
 Wrap=�6n   $�� ��6�   $��Center=�6�   $	��120��6�   �� 5%      $��Number of Hours��6   $
��Left=�66   $��34,0,0,0q�6Q   $��Center=�6c   $ 0.513,0.502&�6~     5&      -   5        $ dpDateOfSelfStudy��5&   !   $
��Left=�6<   $��	282,0,0,0q�6W   $��Center=�6j   $	��120��6�   �� 5'      -   5         ��Name$ cbModuleCode��5'      $
��Left=�65   $��141,145,0,0q�6P   $	��Top=�6e   $	��120��6}   �� 5(      $��Module��6   $
��Left=�6-   $��
88,145,0,0q�6H   $	��Top=�6\   $ 0.513,0.502&�6t   5)      5*      �� 5+      $��Display��6   .��5,      � ���	#FFE5E5E5$��0,0,-2,0q�6.   $	��393��6@   .+�5-      �� -   5        $ btnUpdateDisplay��5-      $��Update Display��67   $��Center=�6P   $��	0,311,0,0q�6m   $	��Top=�6�   $��35��6�   $	��135��6�   6�   &   System.Windows.Controls.DataGrid  5.      -   5          Name$ 
myDataGrid��5.         AutoGenerateColumns$ False��63   $��
16,0,17,93q�6O   	   Columns	 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Module Name��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *
moduleName+  51      $
 Module Code��61    6F   �� *
moduleCode+  52      $
 Number Of Credits��61    6L   �� *numberCredits+  53      $
 Number Of Class Hours��61    6P   �� *numClassHours+  54      $
 Study Hours��61    6F   �� *remainingStudyHours+56      58      59      5:      5<      5=      