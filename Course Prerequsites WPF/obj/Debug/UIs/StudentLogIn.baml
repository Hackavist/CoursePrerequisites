   M S B A M L   `   `   `  ����  Course Prerequsites WPF.    (Course_Prerequsites_WPF.UIs.StudentLogIn   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ StudentLogIn��5   	   $	��650��6   $	��600��6+   .��5      � $��
50,10,80,1q�6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5	      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ BackBTN��5   2    � ToolTip$ Back to Admin Settings��6      MetroCircleButtonStyle#���   6C   $
��Left=�6t   $	��Top=�6�   $��55��6�   $��55��6�   $��0��6�   $��
-37,10,0,0q�6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5      	 j� Stretch$
	 Fill=�6"     appbar_arrow_left
 !� Visual#
 [ 61   5      5      �� 5   
   -   5         ��Name$ VisiblePass_txt��5      $
��Left=�6,   $��38��6G   $��0.333,6.333,0,0q�6S   $	��Top=�6l   $	��298��6�   $��18(�6�   $��2��6�   $��1��6�   $��Segoe UI)�6�   �� 5   
   $��Student Log In��6     PageHeaderTextStyle#��[ 6*   $��2��6W   #��� ��6k   �� 5   
   $��ID��6     SectionHeaderTextStyle#��[ 6   $��0��6N   $��1��6^   $��30(�6k   $��0,66,14.667,0q�6y   ��5      �� 5        �� Color# � ��6"   5"      �� 5#   
   $��Password��6   #��[ 6$   $��0��6T   $��2��6d   $��30(�6q   ��5$      �� 5%      # � ��6"   5'      �� 5(   
   -   5        $ 	idTextBox��5(      $��Stretch=�6%   $	��Top=�6C   $��1��6[   $��1��6k   $��40��6x   $��0.333,66,10.333,0q�6�   $��Segoe UI)�6�   $��18(�6�   $��1��6�   �� 5)   
   -   5        $ loginButton��5)      $��Log In��6&   $��3��67   $��1��6D   $��Center=�6T   $��Center=�6q   $��42��6�   $!��0.333,33.667,135.333,76.333q�6�   $	��173��6�   ���	#FFF6A10C$��Segoe UI)�6�   
�������$��18(�6#  $��Normal"�61  $��3��6E  G� 5*   
   -   5         G�Name$ Password_txt��5*      $
��Left=�6,   $��40��6G   $��0.333,4.333,0,0q�6S   $	��Top=�6l   $	��298��6�    G� PasswordChar$	 ●��6�   $��2��6�   $��2��6�   $��1��6�   $��Segoe UI)�6�   $��18(�6  �� 5+   
   -   5         ��Name$ EyeImage��5+      $
��Left=�6"   $��35��6=   $��257.333,9.333,0,0q�6I   $	��Top=�6d   $��41��6|    J� RenderTransformOrigin$ 3.706,-0.589&�6�   $7��1/Course Prerequsites WPF;component/Images/eye.png��6#  $y�Hidden=�6^  $��1��6r  $��2��6�  52      53      