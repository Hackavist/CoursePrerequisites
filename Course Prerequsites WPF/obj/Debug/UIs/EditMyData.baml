   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   ,    &Course_Prerequsites_WPF.UIs.EditMyData   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Edit My Data��5
   	   $	��650��6   $	��600��6+   .��5      � $��0,0,0.333,0q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� -   5         ��Name$ BackBTN��5   0    � ToolTip$ Back to Student Menu��6      MetroCircleButtonStyle#���   6A   $
��Left=�6r   $��55��6�   $��55��6�   $��0��6�   $��
10,10,0,38q�6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5      	 j� Stretch$
	 Fill=�6"     appbar_arrow_left
 !� Visual#
 [ 61   5      5       �� 5"   
   $��Edit Your Data��6   $��0��6*   $��0��6:   $��2��6G     PageHeaderTextStyle#��[ 6[   #��� ��6�   �� 5$   
   $��0��6   $��1��6$   $��Center=�61   $��Center=�6N     HeaderTextStyle#��[ 6i   $
��Name��6�   #��� ��6�   �� 5%   
   $��0��6   $��2��6$   $��Center=�61   $��Center=�6N   #��[ 6i   $��ID��6�   #��� ��6�   �� 5&   
   $��0��6   $��3��6$   $��Center=�61   $��Center=�6N   #��[ 6i   $��Password��6�   #��� ��6�   �� 5'   
   $��0��6   $��4��6$   $��Center=�61   $��Center=�6N   #��[ 6i   $��Academic Year��6�   #��� ��6�   �� 5)   
   -   5         ��Name$ nameTextBox��5)      $��1��6'   $��1��67   $��Stretch=�6D   $��30,30,30,30q�6b   $��Stretch=�6w   $��Segoe UI)�6�   $��Light"�6�    �� TextWrapping$
 Wrap=�6�   �� 5*   
   -   5        $ 	idTextBox��5*      $��1��6%   $��2��65   $��Stretch=�6B   $��30,30,30,30q�6`   $��Stretch=�6u   $��Segoe UI)�6�   $��Light"�6�   $
 Wrap=�6�    �� 
IsReadOnly .  �� IsUndoEnabled .  6�   �� 5+   
   -   5        $ passwordTextBox��5+      $��1��6,   $��3��6<   $��Stretch=�6I   $��30,35,30,24q�6g   $��Stretch=�6|   $��Segoe UI)�6�   $��Light"�6�   $
 Wrap=�6�   �� 5,   
   -   5        $ 	ayTextBox��5,      $��1��6&   $��4��66   $��Stretch=�6C   $��30,37,30,24q�6a   $��Stretch=�6v   $��Segoe UI)�6�   $��Light"�6�   $
 Wrap=�6�    .  .  6�   �� 5.   
   -   5        $��	Edit Data��5.      $��0��6%   $��2��65   $��5��6I   $��Center=�6V   $��Stretch=�6q   $��140,10,140,10q�6�   $��25(�6�   $��Segoe UI)�6�   $��Light"�6�   
����������	#FFF6A10C6  50      51      