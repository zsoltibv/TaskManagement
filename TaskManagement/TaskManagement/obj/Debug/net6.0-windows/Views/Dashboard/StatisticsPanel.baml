   M S B A M L   `   `   `  ����I  ETaskManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:TaskManagement.Views.PanelsTaskManagement.Views.Panels  5      1    +TaskManagement.Views.Panels.StatisticsPanel   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:TaskManagement.Views.Panels     5        N� Title$  StatisticsPanel��5	      .��5      � 
�������.+�5   
   � .+�5      �� -   5         ��Name$ tasksDueToday��5      $��Tasks due today: ��6+   $
��Left=�6G   $��	10,10,0,0q�6b   $	��Top=�6u   �� 5      $
��Left=�6?   $��
110,10,0,0q�6Z   $	��Top=�6n   $��26��6�   $��22��6�   ��6   �� *StatsVM.Stats.TasksDue+6�   �� 5      -   5        $ tasksDueTommorow��5      $��Tasks due tomorrow: ��6.   $
��Left=�6M   $��	10,36,0,0q�6h   $	��Top=�6{   �� 5      -   5        $ tasksOverdue��5      $��Tasks overdue: ��6*   $
��Left=�6D   $��	10,62,0,0q�6_   $	��Top=�6r   �� 5      -   5        $ 	tasksDone��5      $��Tasks done: ��6'   $
��Left=�6>   $��	10,88,0,0q�6Y   $	��Top=�6l   �� 5      -   5        $ tasksToBeDone��5      $��Tasks to be done: ��6+   $
��Left=�6H   $��
10,114,0,0q�6c   $	��Top=�6w   �� 5      $
��Left=�6G   $��
132,36,0,0q�6b   $	��Top=�6v   $��26��6�   $��22��6�   ��6   �� * StatsVM.Stats.TasksDueTomorrow+6�   �� 5      $
��Left=�6C   $��
100,62,0,0q�6^   $	��Top=�6r   $��26��6�   $��22��6�   ��6   �� *StatsVM.Stats.TasksOverdue+6�   �� 5      $
��Left=�6@   $��	84,88,0,0q�6[   $	��Top=�6n   $��26��6�   $��22��6�   ��6   �� *StatsVM.Stats.TasksDone+6�   �� 5      $
��Left=�6D   $��115,114,0,0q�6_   $	��Top=�6t   $��26��6�   $��22��6�   ��6   �� *StatsVM.Stats.TasksToBeDone+6�   5      5      5      