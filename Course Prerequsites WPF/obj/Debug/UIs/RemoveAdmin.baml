   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fD2clr-namespace:MahApps.Metro;assembly=MahApps.MetroMahApps.Metro 5   	   -    'Course_Prerequsites_WPF.UIs.RemoveAdmin   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	   @f2clr-namespace:MahApps.Metro;assembly=MahApps.Metro     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5
   	    � Title$ RemoveAdmin��5   	   $	��650��6   $	��600��6*   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��0.4* �6   6,   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   .+�5   
   �� -   5         ��Name$ BackBTN��5   2    � ToolTip$ Back to Admin Settings��6      MetroCircleButtonStyle#���   6C   $
��Left=�6t   $��55��6�   $��0��6�   $��10,10,0,126q�6�   $��2��6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5      	 j� Stretch$
	 Fill=�6"     appbar_arrow_left
 !� Visual#
 [ 61   5      5      �� 5"   
   $��2��6   $��1��6(   $��Please Select an Admin..��65   $��Center=�6U   $��Center=�6p     PageHeaderTextStyle#��[ 6�   �� 5$   
   -   5         ��Name$ AdminsCombo��5$      $��Stretch=�6(   $��2��6G   $��Center=�6T   $��100,10,100,10q�6o   �� 5&   
   -   5         ��Name$ Asure��5&      $2��,Are you sure you want to remove this admin ?��6"   $��Center=�6Z   $	��Top=�6x   $��3��6�   �� 5(   
   -   5        $ 	RemoveBTN��5(      $��Remove Admin��6\   $	��Top=�6s   $��Right=�6�   $��0,0,60,0q�6�   $��20(�6�   $��Segoe UI)�6�   $��Light"�6�   
����������	#FFF6A10C$��4��6  {�6$   ��  �� ElementName$ Asure�� �� Path$ 	IsChecked�6'  5)      5*      