   M S B A M L   `   `   `  ���� K  GSimpleScoreboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SimpleScoreboardSimpleScoreboard      SimpleScoreboard.Display   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:SimpleScoreboard       � Title$  Display��
������� � WindowStyle$ 
ToolWindow=�$��ExtraExpanded&�$
��1900��$	��800��$
��1200��$	��300��.���  � ColumnDefinitions �� $��10 ��� -    ��Name$ Column0��$	��10* ��� $	��10* ��� $��10 ��� $	��10* ��� $	��10* ��� $��4* ��� $	��10* ��� $	��10* ��� $��10 ��� $	��10* ��� $	��10* ��� $��10 � � RowDefinitions �� $	��10* ��� $	��60* ��� $	��10* �$��10���� $��1* �.+��� -   $��Score10Team1��$��1��$��1��$��0��$��Ni7seg)�$	��120(�$��Center=�$��Bottom=�
���  ���� -   $��Score1Team1��$��1��$��2��$��0��$��Ni7seg)�$	��120(�$��Center=�$��Bottom=�
���  ���� -   $��Minute1��$��1��$��4��$��0��$��Ni7seg)�$	��120(�$��Center=�$	��Top=�
���   ��� -   $��Minute2��$��1��$��5��$��0��$��Ni7seg)�$	��120(�$��Center=�$	��Top=�
���   ��� -   $��Colon��$��:��$��1��$��0, -30, 0, 0q�$��Center=�$	��Top=�$��6��$	��100(�$
��Bold"��� -   $��Second1��$��1��$��7��$��0��$��Ni7seg)�$	��120(�$��Center=�$	��Top=�
���   ��� -   $��Second2��$��1��$��8��$��0��$��Ni7seg)�$	��120(�$��Center=�$	��Top=�
���   ��� -	   $��Score10Team2��$��1��$��10��$��0��$��Ni7seg)�$	��120(�$��Center=�$��Bottom=�
����  ��� -
   $��Score1Team2��$��1��$��11��$��0��$��Ni7seg)�$	��120(�$��Center=�$��Bottom=�
����  �