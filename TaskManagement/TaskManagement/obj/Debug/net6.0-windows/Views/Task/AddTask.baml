   M S B A M L   `   `   `  ����I  ETaskManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TaskManagement.Views.TaskTaskManagement.Views.Task  5   	   '    !TaskManagement.Views.Task.AddTask   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TaskManagement.Views.Task     5   	     � Title$  AddTask��5   	   $	��300��6   $	��520��6&   .��5	      � .+�5
   
   �� -   5         ��Name$ nameTextBox��5
      $
��Left=�6'   $��	10,26,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $��TextBox��6i   $	��Top=�6x   $	��268��6�   �� 5   
   $��Name
��6   $
��Left=�6)   $��10,0,0,0q�6D   $	��Top=�6V   $��35��6n   �� 5   
   -   5        $ descTextBox��5      $
��Left=�6'   $��
297,26,0,0q�6B   $
 Wrap=�6V   $��TextBox��6j   $	��Top=�6y   $	��196��6�   $	��197��6�   �� 5   
   $��Description��6   $
��Left=�6&   $��	297,0,0,0q�6A   $	��Top=�6T   $��31��6l   �� 5   
   -   5         ��Name$ comboStatus��5      $
��Left=�6(   $��	10,72,0,0q�6C   $	��Top=�6V   $	��125��6n   �� 5   
   $��Status
��6   $
��Left=�6&   $��	10,48,0,0q�6A   $	��Top=�6T   $��35��6l   �� 5   
   -   5        $ comboPriority��5      $
��Left=�6*   $��
153,72,0,0q�6E   $	��Top=�6Y   $	��125��6q   �� 5   
   $��	Priority
��6   $
��Left=�6(   $��
153,44,0,0q�6C   $	��Top=�6W   $��35��6o   �� 5   
   $��	Deadline
��6   $
��Left=�6(   $��	10,99,0,0q�6C   $	��Top=�6V   $��35��6n   �� 5   
   $��	End Date
��6   $
��Left=�6(   $��
153,99,0,0q�6C   $	��Top=�6W   $��35��6o   �� 5   
   -   5        $ comboCategory��5      $
��Left=�6*   $��
10,188,0,0q�6E   $	��Top=�6Y   $	��125��6q   �� 5   
   $��	Category
��6   $
��Left=�6(   $��
10,159,0,0q�6C   $	��Top=�6W   $��35��6o   �� 5   
   -   5        $��Add Task��5      $
��Left=�6$   $��153,188,0,0q�6?   $	��Top=�6T   $	��125��6l   $��22��6x   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateDeadline��5      $
��Left=�6+   $��
10,134,0,0q�6F   $	��Top=�6Z   $	��125��6r     5   
   -   5        $ dateEndDate��5      $
��Left=�6*   $��153,134,0,0q�6E   $	��Top=�6Z   $	��125��6r   5      5      