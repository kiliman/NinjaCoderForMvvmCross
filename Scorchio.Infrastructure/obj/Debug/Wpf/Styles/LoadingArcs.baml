   M S B A M L   `   `   `  ����R  NScorchio.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Scorchio.Infrastructure.Wpf.UserControls(Scorchio.Infrastructure.Wpf.UserControls  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089    LoadingIndicatorArcsStyleKey  �� 
TargetType?    9Scorchio.Infrastructure.Wpf.UserControls.LoadingIndicator �� Property  AccentColorBrush �� Value �� 
TargetType ��Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard    
SpeedRatio	 g� 
SpeedRatio
 g� RepeatBehavior �� 
TargetName �� TargetProperty O� KeyTime O� Value � 	Resources �� ScaleX �� ScaleY T� X T� Y ��Name J� Opacity � 	Transform E� 
StartPoint �� Size �� 
IsLargeArc �� SweepDirection �� Point�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      GuserControls6clr-namespace:Scorchio.Infrastructure.Wpf.UserControls  5      %�  &	        �� 5      "    61   .�5   
   ��  � ��# �  6'   �� 5   
    � ��$ Center=�6.   �� 5   
    � ��$ Center=�60   �� 5   
    � ��$ 40��6"   �� 5	   
    � ��$ 40��6#   �� 5
   
    � �� 5      �� 5      "   6"   .R�5      �� $ PART_Border��6   #��z��62   #��z��6^   #��z��6�    5        5      
SizeStates��. 5   "     	Large��6.     5   "   	Small��6.   5        5      ActiveStates��. 5   "     Inactive��6.     5   "   
Active��. 5   &   �� #	 z 61   .��5   *   U� $
 Forever��6H   $ PART_Canvas0��6a   $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�6�   .\�5   .   �� $ 	0:0:0.000��6C   $ 0Q�6W   �� 5   .   $ 	0:0:3.000��6C   $	 360Q�6W   5   +   U� 5   *   $
 Forever��6H   $ PART_Canvas1��6a   $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�6�   .\�5   .   �� $ 	0:0:0.000��6C   $ 0Q�6W   �� 5   .   $ 	0:0:2.000��6C   $
 -360Q�6W   5   +   5   '   5    #   5!       5$      ���� 5%      '��       "  ��6$   .�5&   "   ��  �@J�RenderTransformOrigin$ 0.5,0.5&�6J   �� 5'   "    � z� 5(   &   �� 5)   *   5+   #   5,      5-      ._�5/      � 
������ z�50      V� 51   "   .~�52   &   �� $	 0.5Q�65   $	 0.5Q�6B   T� 53   &   $ 10Q�69   $ 10Q�6@   54   #   .+�56      �� $ PART_Canvas0��6%   $	 1.0Q�6;   .+�57   "   F� #��z��6'   $��10��6M   ��58   &   B� 59   *    5:   .   T� 5;   2   $ 20Q�6E   $	 -20Q�6L   ��5>   2   D� E� 5?   6   $	 0,0&�6A   ��5A   >   @� �� 5B   B   $ 40,40��6M    . $ CounterClockwise=�6l   $ 40,40&�6�   5C   ?   5E   7   5F   3   5H   +   5J   #   5K      �� 5M      $ PART_Canvas1��6%   $	 0.3Q�6;   .+�5N   "   F� #��z��6'   $��10��6M   ��5O   &   B� 5P   *    5Q   .   T� 5R   2   $ -7Q�6E   $ 7Q�6L   ��5U   2   D� E� 5V   6   $	 0,0&�6A   ��5X   >   @� �� 5Y   B   $ 30,30��6M    . $ 	Clockwise=�6l   $ 40,40&�6�   5Z   ?   5\   7   5]   3   5_   +   5a   #   5b      5c      5d      5e      5g      5h      5i      