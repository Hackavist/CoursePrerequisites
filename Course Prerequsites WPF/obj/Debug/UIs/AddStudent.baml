   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   ,    &Course_Prerequsites_WPF.UIs.AddStudent   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Add Student��5	   	   $	��650��6   $	��600��6*   .��5
      � .+�5   
   �� -   5         ��Name$ BackBTN��5   4    � ToolTip$ Back to Student Settings��6      MetroCircleButtonStyle#���   6E   $��10,10,487,522q�6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5       j� Stretch$
 Fill=�6"     appbar_arrow_left !� Visual# [ 61   5      5      �� 5   
   -   5        	 ��Name$	 StudName��5      $
��Left=�6$   $��34��6?   $��
223,97,0,0q�6K   
 �� TextWrapping$

 Wrap=�6_   $	��Top=�6s   $	��208��6�   $��1��6�   $��Segoe UI)�6�   $��Light"�6�   $��18(�6�   �� 5   
   -   5        $	 StudID��5      $
��Left=�6"   $��34��6=   $��223,180,0,0q�6I   $

 Wrap=�6^   $	��Top=�6r   $	��208��6�   $��2��6�   $��Segoe UI)�6�   $��Light"�6�   $��18(�6�   �� 5   
   -   5        $	 StudPassword��5      $
��Left=�6(   $��34��6C   $��223,267,0,0q�6O   $

 Wrap=�6d   $	��Top=�6x   $	��208��6�   $��3��6�   $��Segoe UI)�6�   $��Light"�6�   $��18(�6�   �� 5   
   -   5         ��Name$ StudYear��5      $
��Left=�6&   $��34��6A   $��223,357,0,0q�6M   $	��Top=�6b   $	��208��6z   & �� ShouldPreserveUserEnteredPrefix . $��4��6�   $��18(�6�   $��Segoe UI)�6�   $��Light"�6�   �� 5   
   $
��Name��6   $
��Left=�6    $��34��6;   $��	20,97,0,0q�6G   $	��Top=�6Z     SectionHeaderTextStyle#��[ 6r   ��5      �� 5       �� Color# � ��6"   5      �� 5   
   $��ID��6   $
��Left=�6   $��34��69   $��
20,180,0,0q�6E   $	��Top=�6Y   #��[ 6q   ��5      �� 5       # � ��6"   5"      �� 5$   
   $��Password��6   $
��Left=�6$   $��34��6?   $��
20,267,0,0q�6K   $	��Top=�6_   #��[ 6w   ��5%      �� 5&      # � ��6"   5(      �� 5*   
   $��Academic Year��6   $
��Left=�6)   $��34��6D   $��
20,357,0,0q�6P   $	��Top=�6d   #��[ 6|   ��5+      �� 5,      # � ��6"   5.      �� 50   
   -   5        $
��Left=�50      $	��100��6+   $	��Top=�68   $	��100��6P   $��480,499,0,0q�6\   $8��2/Course Prerequsites WPF;component/Images/plus.png��6q   6�   52      53      