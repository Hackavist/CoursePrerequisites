   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   ,    &Course_Prerequsites_WPF.UIs.AdminLogIn   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Admin LogIn��5	   	   $	��650��6   $	��600��6*   ��5
      �� 5   
    �� Color$ White��6   .��5      � $��10q�6   .+�5   
   �� -   5         ��Name$ BackBTN��5   -    � ToolTip$ Back to Main Page��6      MetroCircleButtonStyle#���   6>   $��10,10,507,534q�6�   $��4��6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5       j� Stretch$
 Fill=�6"     appbar_arrow_left	 !� Visual#	 [ 61   5      5      �� 5   
   $�� Admin Log In��6   $��50q�6)   $	��Top=�65   $��Center=�6M     PageHeaderTextStyle#��[ 6j   ��5      �� 5      # � ��6"   5      �� 5   
   $��Username��6   $��135,177,-135.4,0q�6$     SectionHeaderTextStyle#��[ 6>   ��5      �� 5       # � ��6"   5"      �� 5$   
   $��Password��6   $��135,334,-135.4,0q�6$   #��[ 6>   ��5%      �� 5&      # � ��6"   5(      �� 5*   
   -   5        
 ��Name$
 Username_txt��5*      $��35��6(   $��135,211,123,0q�64    �� TextWrapping$
 Wrap=�6K   $	��Top=�6_   $��1��6w   $��Segoe UI)�6�   $��18(�6�   �� 5+   
   -   5        $
 VisiblePass_txt��5+      $
��Left=�6,   $��35��6G   $��135,369,0,0q�6S   $	��Top=�6h   $	��316��6�   $��18(�6�   �� 5-   
   -   5        $ 	LogIn_txt��5-      $��Log In��6$   $��42��65   $��226,510,227.333,0q�6A   $	��Top=�6\   $��Segoe UI)�6�   $��22(�6�   $��Light"�6�   ���	#FFF6A10C
�������$��3��6�   G� 5.   
   -   5         G�Name$ Password_txt��5.      $
��Left=�6,   $��35��6G   $��135,369,0,0q�6S   $	��Top=�6h   $	��316��6�    G� PasswordChar$	 ●��6�   $��2��6�   6�   �� 50   
   -   5         ��Name$ EyeImage��50      $
��Left=�6"   $��35��6=   $��410,369,0,0q�6I   $	��Top=�6^   $��41��6v    J� RenderTransformOrigin$ 3.706,-0.589&�6�   $7��1/Course Prerequsites WPF;component/Images/eye.png��6  $y�Hidden=�6X  52      53      