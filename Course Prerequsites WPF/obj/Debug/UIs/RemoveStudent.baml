   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   /    )Course_Prerequsites_WPF.UIs.RemoveStudent   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ RemoveStudent��5
   	   $	��650��6   $	��600��6,   .��5      � .+�5   
   �� -   5         ��Name$ BackBTN��5   2    � ToolTip$ Back to Admin Settings��6      MetroCircleButtonStyle#���   6C   $��10,10,522,534q�6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5       j� Stretch$
 Fill=�6"     appbar_arrow_left !� Visual# [ 61   5      5      �� 5   
   -   5        	 ��Name$	 Title��5      $
��Left=�6#   $��
160,29,0,0q�6>   $
��Wrap=�6R   $��Remove Student��6f   $	��Top=�6|   $	��360��6�   $��76��6�     PageHeaderTextStyle#��[ 6�   #��� ��6�   �� 5   
   -   5        $	 
textBlock1��5      $
��Left=�6(   $��
10,222,0,0q�6C   $
��Wrap=�6W   $��Student ID :��6k   $	��Top=�6   $��38��6�   $	��200��6�     SectionHeaderTextStyle#��[ 6�   #��� ��6�   $��24(�6(  �� 5   
   -   5        
 ��Name$
 comboBox��5      $
��Left=�6%   $��175,222,0,0q�6@   $	��Top=�6U   $	��390��6m   $��38��6y   $��20(�6�   �� 5   
   -   5        $ button��5      $��Remove��6!   $
��Left=�62   $��420,460,0,0q�6M   $	��Top=�6b   $	��145��6z   $��50��6�   #��� ��6�   ���	#FFF6A10C$��Segoe UI)�6�   $��22(�6  $��Normal"�6  62  5      5      