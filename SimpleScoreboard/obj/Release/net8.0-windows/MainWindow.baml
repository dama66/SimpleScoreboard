   M S B A M L   `   `   `  ���� K  GSimpleScoreboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SimpleScoreboardSimpleScoreboard  !    SimpleScoreboard.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:SimpleScoreboard     -     � Title$  Control��
������� � WindowStyle$ 
ToolWindow=�$��ExtraExpanded&�$
��1200��$	��300��$
��1200��$	��300�� � 	Resources    ScoreTeam1Inc  ScoreTeam1Dec 
 MinInc 
 MinDec 	 Start 	 Pause 	 Reset  ScoreTeam2Inc  ScoreTeam2Dec��%�   &	        &	      &	 
     &	      &	      &	      &	      &	 #     &	 (     �� �� �� �� �� �� �� �� ��  J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command# [    -   # [   -   # [   -   # [   -   # [   -   # [   -   # [   -	   # [   -
   # [  J� InputBindings �� 
 �� Key$ A�� �� Command# [  �� $ S��# [ �� $ R��# [ �� $ T��# [ �� $ Z��# [ �� $ U��# [ �� $ I��# [ �� $ K��# [ �� $ L��# [ .���  � ColumnDefinitions �� -   	 ��Name$	 	MwColumn0��$	��10* ��� $	��10* ��� $��40 ��� $	��10* ��� $	��10* ��� $��3* ��� $	��10* ��� $	��10* ��� $��40 ��� $	��10* ��� $	��10* �
 � RowDefinitions
 �� $	��10* ��� $	��60* �$	��150���� $	��30* �$��80��$	��150���� $��60 �.+��� -   $��MwScore10Team1��$��1��$��0��$��0��$��Ni7seg)�$	��120(�$��Center=�$��Bottom=�
���  ���� -   $��MwScore1Team1��$��1��$��1��$��0��$��Ni7seg)�$	��120(�$��Center=�$��Bottom=�
���  ���� -    ��Name$ btnScoreTeam1Inc��$��+��$��2��$��0��$��5q�$��45(�$��	UltraBold"�$��Center=�
�������
���   �$��2q��� -   $ btnScoreTeam1Dec��$��-��$��2��$��1��$��5q�$��45(�$��	UltraBold"�$��Center=�
�������
���   �$��2q��� -   $��	MwMinute1��$��1��$��3��$��0��$��Ni7seg)�$	��120(�$��Center=�$	��Top=�
���   ��� -   $��	MwMinute2��$��1��$��4��$��0��$��Ni7seg)�$	��120(�$��Center=�$	��Top=�
���   ��� -   $��MwColon��$��:��$��1��$��0, -30, 0, 0q�$��Center=�$	��Top=�$��5��$	��100(�$
��Bold"��� -   $��	MwSecond1��$��1��$��6��$��0��$��Ni7seg)�$	��120(�$��Center=�$	��Top=�
���   ��� -   $��	MwSecond2��$��1��$��7��$��0��$��Ni7seg)�$	��120(�$��Center=�$	��Top=�
���   ��� -   $ 	btnMinInc��$��+��$��2��$��3��$��5q�$��45(�$��	UltraBold"�$��Center=�
���iii�
���   �$��2q��� -   $ 	btnMinDec��$��-��$��2��$��4��$��5q�$��45(�$��	UltraBold"�$��Center=�
���iii�
���   �$��2q��� -   $ btnTimerStart��$��Start��$��2��$��6��$��5q�$��25(�$��	UltraBold"�$��Center=�
���iii�
���   �$��2q��� -   $ btnTimerPause��$��Pause��$��2��$��6��$��5q�$��25(�$��	UltraBold"�$��Center=�
���iii�
���   �$��2q��� -   $ btnTimerReset��$��Reset��$��2��$��7��$��5q�$��25(�$��	UltraBold"�$��Center=�
���iii�
���   �$��2q��� -   $��MwScore10Team2��$��1��$��9��$��0��$��Ni7seg)�$	��120(�$��Center=�$��Bottom=�
����  ��� -   $��MwScore1Team2��$��1��$��10��$��0��$��Ni7seg)�$	��120(�$��Center=�$��Bottom=�
����  ��� -   $ btnScoreTeam2Inc��$��+��$��2��$��9��$��5q�$��45(�$��	UltraBold"�$��Center=�
����ح�
���   �$��2q��� -   $ btnScoreTeam2Dec��$��-��$��2��$��10��$��5q�$��45(�$��	UltraBold"�$��Center=�
����ح�
���   �$��2q�