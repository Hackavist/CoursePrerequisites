   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   4    .Course_Prerequsites_WPF.UIs.RegisterToNewCouse   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$ RegisterToNewCouse��5	   	   $	��650��6$   $	��600��61   .��5      �  � RowDefinitions 5   
   �� 5      $	��85* �6   �� 5      $
��534* �6   .+�5   
   �� -   5         ��Name$ BackBTN��5   0    � ToolTip$ Back to Student Menu��6      MetroCircleButtonStyle#���   6A   $
��Left=�6r   $��55��6�   $��0��6�   $��
10,10,0,10q�6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5       j� Stretch$
 Fill=�6"     appbar_arrow_left	 !� Visual#	 [ 61   5      5      �� 5   
   -   5        
 ��Name$
 AvailableCourseBox��5      $
��Left=�6/   $��263,127,0,0q�6J   $	��Top=�6_   $	��307��6w   $��Segoe UI Light)�6�   $��26(�6�   $��55��6�   $��1��6�   �� 5   
   -   5         ��Name$ label��5      $��All Available Courses:��6#   $
��Left=�6A   $��
10,127,0,0q�6\   $	��Top=�6p   $	��265��6�   #��� ��6�   $��26(�6�     SectionHeaderTextStyle#��[ 6�   $��1��6  $��55��6)  �� 5   
   -   5        $ button1��5      $��Register��6"   $
��Left=�65   $��425,340,0,0q�6P   $	��Top=�6e   $	��145��6}   $��65��6�   ���	#FFF6A10C#��� ��6�   $��20(�6  $��Segoe UI)�6  # � ��63  $��1��6�  $��Normal"�6�  �� 5   
   -   5        $ label1��5      $��Registertion Form��6$   $��
160,0,77,0q�6=   $��Bottom=�6Q   $��65��6l   #��� ��6x   $��36(�6�     HeaderTextStyle#��[ 6�   5      5      