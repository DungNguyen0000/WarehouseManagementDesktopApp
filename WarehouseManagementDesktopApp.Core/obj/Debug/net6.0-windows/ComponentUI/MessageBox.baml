   M S B A M L   `   `   `  ����]  YWarehouseManagementDesktopApp.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:WarehouseManagementDesktopApp.Core.ComponentUI.WarehouseManagementDesktopApp.Core.ComponentUI  5      �gclr-namespace:WarehouseManagementDesktopApp.Core.ViewModels;assembly=WarehouseManagementDesktopApp.Core-WarehouseManagementDesktopApp.Core.ViewModels  5	      ?    9WarehouseManagementDesktopApp.Core.ComponentUI.MessageBox   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:WarehouseManagementDesktopApp.Core.ComponentUI     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      w	viewmodelgclr-namespace:WarehouseManagementDesktopApp.Core.ViewModels;assembly=WarehouseManagementDesktopApp.Core  5	      -   5        $
��root��5
        � Title$  
MessageBox��5      $	��550��5      $	��300��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      #  MaterialDesignThemes.Wpf.Card  .��5   
   �� 
���   �$��2q�6%   ._�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��6.5* �6$   �� 5      $
��3.5* �6$   .+�5      � .+�5      ?   9WarehouseManagementDesktopApp.Core.ComponentUI.ControlBar  -   5          Name$ ControlBarElement��5   '   5      � 5      $��1��6   .+�5      � .+�5       �� $��5q�6%   .+�5!      �� $��Center=�6)   .+�5"   "   '  !MaterialDesignThemes.Wpf.PackIcon  $��80��5#   %   $��80��5$   %   $��Center=�5%   %   ��5&   &   �� 5'   *    �� 
TargetType"  60   .�5(   .   ��  �� Property � �� �� Value
 � �|�6K   �� 5)   .    �@ Kind$ CheckCircleOutline=�6E   	 �� Triggers	 5*   .   �� 5+   2   
 �� Binding
 6>   �� *	IsWarning+ �� ElementName$
 root�� �� Value True6n   .a�5,   6   ��  � ��
 �  ��6S   �� 5-   6    �@ Kind$ WarningCircleOutline=�6M   5.   3   50   +   52   #   � 53   "   $��Center=�6,   .+�54   &   �� $��5q�55   )   $��Center=�56   )   $��Center=�57   )   $��DemiBold"�58   )      HeadingText#��[  59   )   $
��Wrap=�5;   )   ��5:   )   �� *ContentText+$
 root��5;   )   5<   #   5=      5?      5@      5A      � 5B      $��2��5C      $��0,5,0,20q�5D      $��Center=�5E      $��Bottom=�5F      .+�5G      �� -   5        $��4��5H      $	��170��5I      $��50��5J      ���#DDDDDD$��0q�5L      $��25(�5O      $
��Bold"�5P        SistrainColorBrush#��[ 5Q       �� 	IsDefault$
 True��5R        MaterialDesignFlatButton#��[ 5S      ��5N      �� *ConfirmCommand+.��5S   K   Xác Nhận5U      5V      5W      5X      5Y      5Z      