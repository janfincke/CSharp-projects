   M S B A M L   `   `   `  ����   EX 09 Control Template Final-    'EX_09_Control_Template_Final.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��357��6   $	��650��6)   .��5      � D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6   :x,http://schemas.microsoft.com/winfx/2006/xaml     6M    � 	Resources 5   
      buttonTemplate �� 
TargetType A�Name �� 
StartPoint �� EndPoint � Offset � Color �� RelativeSource	 �� Path
 J� RenderTransformOrigin �� ScaleX �� ScaleY �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value��%�  &	        �� 5      " ��65   .R�5      � .+�5	      A� $ outerCircle��6   ��5
      �� 5      $	 0,0&�62   $	 0,1&�6C   .��5   "   � $ 0Q�6/    5      ��  �� *TemplatedParent+$	 Background.Color�� 5   "   $ 1Q�6/   $	 Red��6:   5      5      A� 5      $
 .5,.5&�6   z�5      �� 5      $ .8Q�6-   $ .8Q�69   ��5      �� 5      $	 0,0&�62   $	 0,1&�6C   .��5   "   � $ 0Q�6/   $ White��6:   � 5   "   $ 1Q�6/   $ Transparent��6:   5      5      (� 5      .��5      �� #��z��6+   5       5!       5"      P� 5#       �@J�IsMouseOver . . �5$      �� $ outerCircle��6!    � ��
 � ���6J   5%      P� 5&       � �� . . �5'      ��  � z� 5(      �� 5)   "   $ .9Q�61   $ .9Q�6=   5+      �� 5,       �@J�RenderTransformOrigin$ .5,.5&�6B   5-      5/      50      .+�51   
   ��  �� Orientation$ 
Horizontal=�6   .+�52      �� #��[  6   $	��100��6@   $	��100��6M   $��80(�6Y   
���   �$��20q�53      $��5q�6,   .��67   16:   �� 54      #��[  6   $	��150��6@   $	��250��6M   $��80(�6Y   
��� ���$��20q�55      $��5q�6,   .��67   26:   �� 56      #��[  6   $	��200��6@   $	��200��6M   $��80(�6Y   
�������$��20q�57      $��5q�6,   .��67   36:   58      59      5:      