   M S B A M L   `   `   `  ����L  HPruebaUserControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:PruebaUserControl.UserControlsPruebaUserControl.UserControls  5      :    4PruebaUserControl.UserControls.LimitInputUserControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:PruebaUserControl.UserControls     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� ��6   �� *Title+�� 5   
   $��1��6   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� ��6   ��  �� ElementName$ txtLimitedInput�� �� Path$ Text.Length��� 5      $��/��6   �� 5      ��6   �� *	MaxLength+5      5      �� 5   
   -   5        $��txtLimitedInput��5   S   $��1��62   $��2��6?   $
��Auto=�6j    �� TextWrapping$
 Wrap=�6�    �� 	MaxLength 6   �� *	MaxLength+6�   5      5      