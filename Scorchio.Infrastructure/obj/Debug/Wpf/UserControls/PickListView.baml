   M S B A M L   `   `   `  ����  Scorchio.Infrastructure;    5Scorchio.Infrastructure.Wpf.UserControls.PickListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          >�Name$  uc��5       � 	Resources 5         ListViewHeaderStyle �� 
TargetType �� Property �� Value��%Y   &	        �� 5   
   " ��6,   .�5      ��  � y�$ 	Collapsed=�6+   5      5	      .��5
      �� $��	10,0,10,0q�6   ��5   
   �� 5      .R�5      �� 
���������6/   ��  �� Path$ GroupBoxTitle� �� ElementName$ uc��5      .��5   
   � .+�5      �� $��0q�6   ��6+   �� $ DataContext�$ uc����5      �� 5      " ��6   .�5      ��  �@�ToolTip 64   �� *Item.Description+5      ��5      �� 5      .R�5      �  � Orientation$ 
Horizontal=�5!   $   ��5   $   �� * (FrameworkElement.ActualWidth)+ �� RelativeSource �� 	 �� AncestorType$	 ScrollContentPresenterL���5   $   �� *	ItemWidth+ �� *Self+
 � 
ItemHeight
 5   $   �� *(ListView.View).ItemHeight+ �� $	 ListViewL� � 	ItemWidth 5   $   �� *(ListView.View).ItemWidth+ �� $	 ListViewL�5!   $   5"       �� View 5%      �� 5&      ! �� ColumnHeaderContainerStyle# [  6   .P�5'      ��  �� CellTemplate 5(      �� 5)   "   .R�5*   &   �� .+�5+   *   ��  d� 	IsChecked 63   �� *
IsSelected+{�6T   �� *	IsEnabled+5,   '   5-   #   5/      �� 50       �� DisplayMemberBinding 6)   �� *Item.FriendlyName+51      53      54      55      56      