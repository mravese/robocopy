   M S B A M L   `   `   `  ����F  BRobocopyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RobocopyWPFRobocopyWPF  5   	       RobocopyWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:RobocopyWPF     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $$��Source and destination targets��6   $
��Left=�69   $��	52,44,0,0q�6T   $	��Top=�6g   �� 5   
   $��Source Directory��6   $
��Left=�6+   $��	52,70,0,0q�6F   $	��Top=�6Y   �� 5   
   -   5         ��Name$ tbSourceDirectory��5      $
��Left=�6-   $��23��6H   $��	55,96,0,0q�6T    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��600��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.005Q�6&   T� 5      5      .��5   '   5      �� 5   
   -   5         ��Name$ btnSourceDirectory��5      $��SELECT��6-   $
��Left=�6>   $��
666,96,0,0q�6Y   $	��Top=�6m   $��75��6�   6�   �� 5   
   $��Target Directory��6   $
��Left=�6+   $��
55,131,0,0q�6F   $	��Top=�6Z   �� 5   
   -   5        $ tbTargetDirectory��5      $
��Left=�6-   $��23��6H   $��
55,163,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��600��6�   $ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5      $ -0.005Q�6&   T� 5      5       .��5!   '   5"      �� 5#   
   -   5        $ btnTargetDirectory��5#      $��SELECT��6-   $
��Left=�6>   $��666,163,0,0q�6Y   $	��Top=�6n   $��75��6�   6�   �� 5$   
   $��Copy Options��6   $
��Left=�6)   $��64��6D   $��
52,196,0,0q�6P   $	��Top=�6d   $	��318��6|   .��5%      	� -   5         	�Name$	 rbS��5%      $5��//S Copies subdirectories (excluding empty ones)��6'   $
��Left=�6a   $��	10,10,0,0q�6|   $	��Top=�6�   5&      	� 5'   
   -   5        $	 rbE��5'      $9��3/E Copies all subdirectories (including empty ones)��6#   $
��Left=�6a   $��
68,245,0,0q�6|   $	��Top=�6�   �� 5(   
   -   5        $ btnRun��5(      $��RUN ROBOCOPY��6!   $
��Left=�68   $��377,391,0,0q�6S   $	��Top=�6h   $	��106��6�   $ 0.094,0.686&�6�   6�   5*      5+      