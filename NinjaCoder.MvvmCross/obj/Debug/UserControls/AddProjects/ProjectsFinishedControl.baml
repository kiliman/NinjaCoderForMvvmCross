   M S B A M L   `   `   `  ����  NinjaCoder.MvvmCrossK    ENinjaCoder.MvvmCross.UserControls.AddProjects.ProjectsFinishedControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5         BoolToVisibility�� 5	   
   %   &	        �� 5
      6+   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��2��5      $��0��5      $��30q�5      $	��Top=�5      $R��Lpack://application:,,,/NinjaCoder.MvvmCross;component/Resources/lefthand.png��5      �� 5   
   $��0��6   $��1��5       $	��500��5!      $	��600��5"       �� Orientation$ Vertical=�5#      .+�5%      �� $��5q�6   �� 5'      $��10q�6   $y�	Collapsed=�5(      $9��3Suspend ReSharper during Ninja creation of projects��5)       d� 	IsChecked 5*      �� *SuspendReSharperDuringBuild+�� 5,      $��10q�6   $5��/Create Test projects in 'Tests' solution folder��5-       5.      �� *" CreateTestProjectsSolutionFolder+�� 50      $��10, 0, 0 ,2q�6   $��Startup Project��6-   y�6D   �� *DisplayStartUpProject+ �� 	Converter# [  �� 52      $	��250��6   $��10,0,0,3q�53      $
��Left=�55      y�54      �� *DisplayStartUpProject+# [  ��56      �� *StartUpProjects+ �� SelectedItem 57      ��  �� Path$ SelectedStartUpProject� �� Mode$ TwoWay=�9� 59      $��10q�6   $��Code Formatting options��5:      	 9� 
IsExpanded	 5;      �� *ExpandCodeFormattingOptions+.��5=      �� $��10q�6   .+�5?      �� $��10,5,0,0q�6   $��Remove File Headers��5@       5A      �� *RemoveDefaultFileHeaders+�� 5C      $��10,5,0,0q�6   $��Remove Xml Code Comments��5D       5E      �� *RemoveDefaultComments+�� 5G      $��10,5,0,0q�6   $"��Remove use of 'this' pointer��5H       5I      �� *RemoveThisPointer+5J      5K      �� 5M      $��Disabled=�6   $
��Auto=�6D   .��5N      �� $��3q�6   .+�5O      �� $��10q�6    $,��&The following projects will be created��6,   6\   �� 5P      $��0q�6   ��63   �� *
Projects+��5Q      �� 5R      
 �� 
TargetType"
 ��6$   .�5S   "   ��  �� Property � |� �� Value .  6>   5T        5V      ��%Y   '��       �� 5W      "
 ��6$   .�5X   "   ��  � y�$ 	Collapsed=�6?   5Y      5Z       �� View 5[      �� 5\      .P�5]   "   ��  �� DisplayMemberBinding 61   �� 5^      5`      �� 5a      $��10q�6    �� 5b      .�6"   97(Project Suffixes can be amended in the Options Screen)6[   5c      5d      5e      5f      5h      5j      