   M S B A M L   `   `   `  ����B  >quizapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:quizappquizapp  5   	       quizapp.view   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialdesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:quizapp  5   	     � Title$  adminsoption��5	   	   $	��650��6   $	��650��6+   ���#04c582 � WindowStyle$
 None=�6L   .��5
      ��  �� CornerRadius$ 20��6   $��20q�6   
���   �._�5   
   �� .+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      �� -   5        $��miner��5      $��-��6&   
�������$��40(�6E   
���   �6}   �� 5      -   5        $��closer��5      $��X��6'   
�������
���   �$��10 0 0 0q�6p   $��30(�6�   $
��Left=�6�   6�   5      �� 5      -   5        $
��back��5      .+�5      �� -   5         ��Name$ backbtn��5      $��60��6?   $��60��6J   $	��Top=�6�   $
��Left=�6�   ��6V   Z� ��6l   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  
��������  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�6A   $��25��6R   $��25��6^   6k   5      5      �� 5      $ 
Horizontal=�6   $��20q�66   .+�5      �� $��Students��6   
�������$��25(�6B   $
��40 0q�6P   6`   �� 5      $��	Questions��6   
�������$��25(�6C   $
��80 0q�6Q   6a   5      �� 5      $ 
Horizontal=�6   $
��40 0q�66   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��datagrid��5         AutoGenerateColumns . $	��260��6C   $	��200��6P   6^     5      -   5        $��	qdatagrid��5       . $��30q�6K   $	��260��6X   $	��260��6e   6s   5      �� 5      $��30q�6   .+�5       �� -   5        $��delete��5       $��Delete Data��6+   $	��120��6A   $��20(�6M   
����������#545d6a6�   5"      5$      5&      5(      5*      