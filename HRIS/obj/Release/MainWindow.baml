   M S B A M L   `   `   `  ����   HRIS    HRIS.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  
MainWindow��$��647.784��$��946.337��.��� $��0,0,5,-0.429q� � ColumnDefinitions �� $	��40* ��� $
��268* ��� $	��68* ��� $
��559* � � RowDefinitions �� $	��37* ��� $
��173* ��� $	��52* ��� $	��48* �.+��� $��4��$
��Left=�$	��524��$��10,8.286,0,0q�$��1��$	��Top=�$	��925��$��3��.@��� $��Staff�� J� RenderTransformOrigin$ 
2.688,1.57&�.��� 
�������$��10,13,9,3.429q�.+��� -    ��Name$ 	StaffList��$��33,87,659,10.571q�   StaffListTemplate#��[  ����   	StaffList �� Source# [ �� $��Filter by name��$
��Left=�$��	23,33,0,0q�$	��Top=�$��23��$��62��$��8(��� -    ��Name$ NameBox��$��23��$��89,33,658.571,0q� �� TextWrapping$
 Wrap=�$	��Top=��� $��Show:��$
��Left=�$��	33,56,0,0q�$	��Top=�$��9(�$��22��$��34���� -    ��Name$ CategoryBox��$��77,60,658.571,0q�$	��Top=�$��22������   Category# [ � -   	 �Name$	 
DetailGrid��$
��Left=�$	��429��$��
249,43,0,0q�$	��Top=�$	��643��.+��� $��Name:��$
��Left=�$��	72,15,0,0q�$	��Top=�$ 
2.03,0.649&��� $
��Left=�$��
141,15,0,0q�$	��Top=�$	��290��$��26������ *
FullName+�� $��Campus:��$
��Left=�$��	72,41,0,0q�$	��Top=��� $
��Left=�$��
141,41,0,0q�$	��Top=�$	��290��$��26������ *Campus+�� $��Phone:��$
��Left=�$��	72,70,0,0q�$	��Top=��� $
��Left=�$��
141,67,0,0q�$	��Top=�$	��290��$��24������ *Phone+�� $��Room:��$
��Left=�$��	72,96,0,0q�$	��Top=��� $
��Left=�$��
141,91,0,0q�$	��Top=�$	��290��$��31������ *Room+�� $��Email:��$
��Left=�$��
72,121,0,0q�$	��Top=��� $
��Left=�$��141,121,0,0q�$	��Top=�$	��290��$��32������ *Email+�� $��Consultatin hours:��$
��Left=�$��
72,146,0,0q�$	��Top=�$	��152���� -   $
��Left=�$��73��$��
72,173,0,0q�$	��Top=�$	��251������ *ConsultationTime+�� $��Teaching this semester��$
��Left=�$��
72,251,0,0q�$	��Top=�$	��140���� -   $ UnitList��$
��Left=�$��73��$��
72,277,0,0q�$	��Top=�$	��251������ *TeachingUnit+�� $
��Unit��.��� 
�������$��10,13,9,3.429q� �� $	��11* ��� $
��888* �.+��� $��Filter by name��$
��Left=�$��11.667,33,0,0q�$	��Top=�$��36��$��88��$��1���� -   $ UnitName��$��23��$��104.667,33,574.666,0q�$
 Wrap=�$	��Top=�$��1���� -   $ UnitBox��$��21.667,87,574.666,10.904q�
 �� SelectedValuePath$

 Code��$��1������   UnitList# [ ����   UnitListTemplate# [ &   System.Windows.Controls.DataGrid  -	     Name$ 	ClassList��   AutoGenerateColumns .     
IsReadOnly . $��356.667,87,141.666,10.904q�$��1������   	ClassList# [    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 Day��1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$	 Day�  $ Start�� �� $ Start�  $	 End�� �� $	 End�  $
 Type�� �� $ 	ClassType�  $
 Room�� �� $
 Room�  $ Campus�� �� $ Campus�  $ Staff�� �� $ staff��� $��Filter by campus��$
��Left=�$��485.667,46,0,0q�$	��Top=�$��36��$	��124��$��1���� -
   $ 	CampusBox��$
��Left=�$��626.667,47,0,0q�$	��Top=�$	��120��$��1������  
 Campus# [ 