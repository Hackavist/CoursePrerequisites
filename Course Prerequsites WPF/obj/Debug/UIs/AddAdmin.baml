   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   +    %Course_Prerequsites_WPF.UIs.Add_Admin   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 	Add Admin��5	   	   $	��650��6   $	��600��6(   .��5
      � $��7q�6    � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   6.   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� -   5         ��Name$ BackBTN��5   2    � ToolTip$ Back to Admin Settings��6      MetroCircleButtonStyle#���   6C   $	��Top=�6t   $
��Left=�6�   $��55��6�   $��55��6�   $��0��6�   $��	10,10,0,0q�6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5      	 j� Stretch$
	 Fill=�6"     appbar_arrow_left
 !� Visual#
 [ 61   5      5      �� 5    
   $��
62,85,0,37q�6   $��	Username ��6(     SectionHeaderTextStyle#���  69   $
��Left=�6j   $��Center=�6�   $��0��6�   $��0��6�   ��5!      �� 5"       �� Color# � ��6"   5$      �� 5%   
   $��
62,61,0,61q�6   $��	Password ��6(   #���  69   $
��Left=�6j   $��Center=�6�   $��0��6�   $��1��6�   ��5&      �� 5'      # � ��6"   5)      �� 5*   
   $��
62,62,0,62q�6   $��Manager ��6(   #���  68   $
��Left=�6i   $��Center=�6�   $��0��6�   $��2��6�   ��5+      �� 5,      # � ��6"   5.      �� 50   
   -   5         ��Name$ Username��50      $��Stretch=�6%   $��Center=�6C   $��10,87,10,38q�6^   $��1��6s   $��0��6�   �� 51   
   -   5        $ Password��51      $��Stretch=�6$   $��Center=�6B   $��10q�6]   $��1��6i   $��1��6y   �� 52   
   -   5         ��Name$ GeneralManagerCheck��52      $
��Left=�60   $��Center=�6K   $��10q�6f   $��1��6r   $��2��6�   �� 54   
   -   5         ��Name$	 Add��54      $8��2/Course Prerequsites WPF;component/Images/plus.png��6   $��Right=�6Y   $��10q�6u   $��3��6�   $��1��6�   6�   55      56      