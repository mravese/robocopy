   M S B A M L   `   `   `  ����F  BRobocopyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RobocopyWPFRobocopyWPF  5   	       RobocopyWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:RobocopyWPF     5   	   -   5          � Title$  RobocopyGUI��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�6O   $	��450��6t   $	��800��6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��7* �6   �� 5      $
��786* �6    � RowDefinitions 5   
   �� 5      .+�5   
   �� ���	#FF6868E5$	��100��6%   
���   �$	��Top=�6A   $��
0,0,-0.4,0q�6Y   $��2��6m   �� 5   
   $$��Source and destination targets��6   $��42.8,35,0,359q�69   $
��Left=�6P    J� RenderTransformOrigin$ 0.5,0.5&�6k   $��25.96��6�   $��171.96��6�   $��1��6�   �� 5   
   $��Source Directory��6   $��92.8,129,99.6,0q�6+   $	��Top=�6D   $��25.96��6\   $��1��6n   �� 5   
   -   5         ��Name$ tbSourceDirectory��5      $��23��6-   $��92.8,160,199.6,0q�69    �� TextWrapping$
 Wrap=�6S   $ 0.5,0.5&�6g   $	��Top=�6�   $��23��6�   $��1��6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.005Q�6&   T� 5      5      .��5   '   5      �� 5    
   -   5         ��Name$ btnSourceDirectory��5       $��SELECT��6-   $��0,160,99.6,0q�6>   $	��Top=�6T   $��23��6�   $��80��6�   $��23��6�   $��Right=�6�   $��1��6�   �� 5"   
   $��Target Directory��6   $��92.8,190,99.6,0q�6+   $	��Top=�6D   $��25.96��6\   $��1��6n   �� 5#   
   -   5        $ tbTargetDirectory��5#      $��23��6-   $��92.8,218,199.6,0q�69   $
 Wrap=�6S   $	��Top=�6g   $ 0.5,0.5&�6   $��23��6�   $��1��6�   .��6�   z�5$      V� 5%      .~�5&      �� �� 5'      �� 5(      $ -0.005Q�6&   T� 5)      5*      .��5+   '   5,      �� 5-   
   -   5        $ btnTargetDirectory��5-      $��SELECT��6-   $��0,218,99.6,0q�6>   $	��Top=�6T   $��23��6�   $��80��6�   $��23��6�   $��Right=�6�   $��1��6�   �� 5.   
   -   5        $ btnRun��5.      $��RUN ROBOCOPY��6!   $��337.8,0,338.6,10q�68   $ 0.5,0.5&�6R   $��Bottom=�6�   $��1��6�   �� 5/   
   -   5        	 ��Name$	 gbCopyOptions��5/      $��Copy Options��6*   $��92.8,250,387.6,0q�6@   $	��Top=�6Z   $��1��6r   $��70��6�   $��70��6�   $	��306��6�   $	��306��6�   $
��Left=�6�   .��50      �� -   5        
 ��Name$
 spCopyOptions��50      $
��Left=�60   $��0,10,-2,-12.4q�6K   $	��290��6b   $��80��6n   $	��Top=�6z   .+�51      	� -	   5         	�Name$	 rbS��51      $5��//S Copies subdirectories (excluding empty ones)��6+   $
��Left=�6e   $	��Top=�6�   	� 52      -
   5        $	 rbE��52      $9��3/E Copies all subdirectories (including empty ones)��6+   $
��Left=�6i   $	��Top=�6�   53      54      55      56      