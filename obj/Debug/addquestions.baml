   M S B A M L   `   `   `  ����B  >quizapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:quizappquizapp  5   	       quizapp.addquestions   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialdesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:quizapp  5   	     � Title$  addquestions��5
   	   $	��650��6   $	��800��6+   ���#04c582.��5      �� 
���   � �� CornerRadius$ 20��6    $��20q�62   ._�5   
   �� .+�5      �� .+�5      �� -   5         ��Name$ btnback��5      $��60��6@   $��60��6K   $	��Top=�6�   $
��Left=�6�   ��6W   Z� ��6m   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  
��������  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�6A   $��25��6R   $��25��6^   6k   5      5      �� 5       �� Orientation$ Vertical=�6   $
��20 1q�60   .+�5      �� $��Add questions��6   
�������$��25(�6?   $��Center=�6M   6l   �� 5      6   �� 5      $��Question��6   
�������6=   �� 5      -   5        $
��txtQ��5      ���#545d6a
�������$��20(�6J   6Z   �� 5      $��optionA��6   
�������6<   �� 5      -   5        $��txtopa��5      ���#545d6a
�������$��20(�6L   6\   �� 5      $��optionB��6   
�������6<   �� 5      -   5        $��txtopb��5      ���#545d6a
�������$��20(�6L   6\   �� 5      $��optionC��6   
�������6<   �� 5      -   5        $��txtopc��5      ���#545d6a
�������$��20(�6L   6\   �� 5      $��optionD��6   
�������6<   �� 5      -   5        $��txtopd��5      ���#545d6a
�������$��20(�6L   6\   �� 5       $��
correctAns��6   
�������6?   �� 5!      -   5        $��txtans��5!      ���#545d6a
�������$��18(�6L   6\   �� 5$      -   5        $ 	btnsubmit��5$      $��submit��6(   $
��Left=�6K   $	��100��6f   $��60 10q�6s   ���#545d6a
�������$��18(�6�   5%      5&      5'      5)      