   M S B A M L   `   `   `  ����X  TWarehouseManagementDesktopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:WarehouseManagementDesktopApp.Views.GoodReceipts0WarehouseManagementDesktopApp.Views.GoodReceipts  5      ] YWarehouseManagementDesktopApp.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�wclr-namespace:WarehouseManagementDesktopApp.Core.ValueConverter.MyApp.Tools;assembly=WarehouseManagementDesktopApp.Core=WarehouseManagementDesktopApp.Core.ValueConverter.MyApp.Tools 5      �Hclr-namespace:WarehouseManagementDesktopApp.Resources.Components.Message:WarehouseManagementDesktopApp.Resources.Components.Message  5      K    EWarehouseManagementDesktopApp.Views.GoodReceipts.GoodReceiptOrderView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      Jlocal>clr-namespace:WarehouseManagementDesktopApp.Views.GoodReceipts  5      _	 [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006 	 5	      T
 PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/ 
 5
      �toolswclr-namespace:WarehouseManagementDesktopApp.Core.ValueConverter.MyApp.Tools;assembly=WarehouseManagementDesktopApp.Core 
 5      QucHclr-namespace:WarehouseManagementDesktopApp.Resources.Components.Message 
 5      -   5          >�Name$  GoodReceiptOrder��5      $��1267.2��5      $	��824��5         MaterialDesignPaper#���   5        MaterialDesignFont#���  5      $��13(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5      .��5      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $
��6.5* �6   �� 5      $
��0.5* �6   .+�5   
   �� $��1��6   $��80��5      $��80��5       $��20,0,0,0q�5!        MoveBackButton#��[ 5"      .��5#      ' 	 !MaterialDesignThemes.Wpf.PackIcon  $	��100��6&   $��50��5$   &   $��Center=�5%   &   ���#fff   Kind$ 	ArrowBack=�5'   &    J� Opacity$ 1Q�5(   &   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5)      +  %Microsoft.Xaml.Behaviors.EventTrigger  5*         	EventName$ Click��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5+      - 
 'Prism.Interactivity.InvokeCommandAction  	   Command	 60   �� *NavigateGoodReceiptView+5,      5.      � 5/   
   $��0��6   .+�50      � $	��700��6   $��80��51      
 � ColumnDefinitions
 52      �� 53      $��9* �6'   �� 54      $��1* �6'   .+�56      �� $��0��6   $��20,0,0,0q�57      $��Center=�58      $��Center=�59      ) 	 #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5:      . 	 (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5;      $��0q�5<      $��30(�5=      ��5>      �� *
FilePath+�� 5?      
���   �$��1,1,0,1q�5@       �� CornerRadius$ 	30,0,0,30��5A      � 5B      $��1��6   .+�5C      �� 
���   �$��0,1,1,1q�5D      $ 	0,30,30,0��5E      �� 5F      $��1��6   $��Right=�5G      $��Center=�5H      
���   �$��0,1,1,1q�5J        MaterialDesignIconButton#���  5K      .��5L        $��50��62   $��30��5M   2   $ Magnify=�5N   2   $	 .56Q�5O   2   5P      5Q      5S      5U      �� 5V   
   $	��150��6   $��60��5W      $��1021,94,96,93q�5X      $��Tải file Excel��5Z      $��20(�5[        
MenuButton#��[ 5\      ��5Y      �� *
UploadFile+5\      � 5]   
   $��1��6   
 5^      �� 5_      $
��3.5* �6#   �� 5`      $
��6.5* �6#   .+�5b      � $��1��6    5c      �� 5d      $
��auto �6$   �� 5e      $��* �6$   .+�5g      �� $
��Auto=�6   .��5h      #	 	 MaterialDesignThemes.Wpf.Card	  $��1��6*   $	��824��5i   *   $	��400��5j   *   $��Center=�5k   *   .��5m      �� ._�5n      &
   System.Windows.Controls.DataGrid
  $��0,5,0,0q�6'    
  RowBackground �	#FFD4D6EA 
  AlternatingRowBackground
 �����$	��Top=�5q   '    
  AutoGenerateColumns$ False��5r   '   
���   �  DataGridColumnHeaderStyle2 
  ColumnHeaderStyle# [ 5t   '   $��0q�5u   '   ! 
  EnableColumnVirtualization$ False��5v   '    
  AreRowDetailsFrozen$
 True��5w   '    
  SelectionMode$ Extended=�5x   '    
  GridLinesVisibility$
 None=�5y   '   $ 
  HorizontalScrollBarVisibility$
 Auto=�5z   '   $��Center=�5{   '    
  CanUserReorderColumns$ False��5|   '     DataGrid#��[ 5   '   $	��395��5�   '   ��5}   '   �� *GoodsReceiptList+ �� Mode$ TwoWay=� �� SelectedIndex 5~   '   �� *SelectedIndexItem+$ TwoWay=� � 	Resources 5�   "   =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%  '        �� 5�   &   "  6,   .�5�   *   ��  � ��$ Center=�5�   1   �� 5�   *    � �� �	#FF00294D5�   1   �� 5�   *    � ��
 �����5�   1   �� 5�   *    � ��$ 20��5�   1   �� 5�   *    � ��$ Center=�5�   1   5�   '   5�   #    
  	CellStyle 5�   "   �� 5�   &   *  $System.Windows.Controls.DataGridCell"  6,    �� Triggers 5�   *   P� 5�   .     P� Property  �@ 
IsSelected! P� Value$
! True��5�   6   . �5�   2   ��  � ��
 �����5�   9   �� 5�   2    � ��$ 20(�5�   9   5�   /   5�   '   " 
  Columns" 5�   "   0  *System.Windows.Controls.DataGridTextColumn  5�   &   ,  &System.Windows.Controls.DataGridColumn#   Width5  /System.Windows.Controls.DataGridLengthConverter$# 80 69   1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 5�   9   �� *Id+%   HeaderTemplate% 5�   *   �� 5�   .   .R�5�   2   �� $��0,4,0,2q�6=   $��Center=�5�   =   & �� Orientation$& 
Horizontal=�5�   =   .+�5�   6   �� ' �� Padding$' 0,0,5,5q�6@   $��25(�5�   @   $	��STT��5�   @   5�   3   5�   /   (   
Foreground( 5�   *   �� 5�   .   ) �� Color$) Black��6>   *   ElementStyle* 5�   *   �� 5�   .   " ��64   .�5�   2   ��  � ��$ Center=�5�   9   �� 5�   2    � ��
 ���� 5�   9   �� 5�   2    � {�$ False��5�   9   �� 5�   2    � ��$ 25��5�   9   �� 5�   2    � ��$ 20(�5�   9   5�   /   5�   '     5�   &   $	# 150 69   $ 5�   9   �� *	ProductId+% 5�   *   �� 5�   .   .R�5�   2   �� $��0,4,0,2q�6=   $��Center=�5�   =   $& 
Horizontal=�5�   =   .+�5�   6   �� $' 0,0,5,5q�6@   $��25(�5�   @   $��Mã SP��5�   @   5�   3   5�   /   ( 5�   *   �� 5�   .   $) Black��6>   * 5�   *   �� 5�   .   " ��64   .�5�   2   ��  � ��$ Center=�5�   9   �� 5�   2    � ��
 ���� 5�   9   �� 5�   2    � {�$ False��5�   9   �� 5�   2    � ��$ 25��5�   9   �� 5�   2    � ��$ 20(�5�   9   5�   /   5�   '     5�   &   $	# 200 69   $ 5�   9   �� *ProductName+% 5�   *   �� 5�   .   .R�5�   2   �� $��0,4,0,2q�6=   $��Center=�5�   =   $& 
Horizontal=�5�   =   .+�5�   6   �� $' 0,0,5,5q�6@   $��25(�5�   @   $��Tên SP��5�   @   5�   3   5�   /   ( 5�   *   �� 5�   .   $) Black��6>   * 5�   *   �� 5�   .   " ��64   .�5�   2   ��  � ��$ Center=�5�   9   �� 5   2    � ��
 ���� 5  9   �� 5  2    � {�$ False��5  9   �� 5  2    � ��$ 25��5  9   �� 5  2    � ��$ 20(�5  9   5  /   5
  '     5  &   $	# 150 69   $ 5  9   �� *Mass+% 5  *   �� 5  .   .R�5  2   �� $��0,4,0,2q�6=   $��Center=�5  =   $& 
Horizontal=�5  =   .+�5  6   �� $' 0,0,5,5q�6@   $��25(�5  @   $��Khối lượng��5  @   5  3   5  /   ( 5  *   �� 5  .   $) Black��6>   * 5  *   �� 5  .   " ��64   .�5  2   ��  � ��$ Center=�5   9   �� 5!  2    � ��
 ���� 5"  9   �� 5#  2    � {�$ False��5$  9   �� 5%  2    � ��$ 25��5&  9   �� 5'  2    � ��$ 20(�5(  9   5)  /   5+  '     5,  &   $	# 260 69   $ 5-  9   �� *
Quantity+$ TwoWay=�% 5/  *   �� 50  .   .R�51  2   �� $��0,4,0,2q�6=   $��Center=�52  =   $& 
Horizontal=�53  =   .+�54  6   �� $' 0,0,5,5q�6@   $��25(�55  @   $��Số Lượng (bộ/cái)��56  @   57  3   58  /   ( 5:  *   �� 5;  .   $) Black��6>   * 5=  *   �� 5>  .   " ��64   .�5?  2   ��  � ��$ Center=�5@  9   �� 5A  2    � ��
 ���� 5B  9   �� 5C  2    � {�$ False��5D  9   �� 5E  2    � ��$ 25��5F  9   �� 5G  2    � ��$ 20(�5H  9   5I  /   5K  '     5L  &   $	# 200 69   $ 5M  9   �� *Unit+% 5O  *   �� 5P  .   .R�5Q  2   �� $��2,4,2,2q�6=   $& 
Horizontal=�5R  =   .+�5S  6   �� $' 0,0,5,5q�6@   $��25(�5T  @   $��
Đơn vị��5U  @   !  FontAwesome.WPF.FontAwesome  5V  6   $��30��6E   $��	5,10,0,-2q�5W  E   ���	#FF68EB48+   Icon$+ 	ArrowDown=�5Y  E   5Z  3   5[  /   ( 5]  *   �� 5^  .   $) Black��6>   * 5`  *   �� 5a  .   " ��64   .�5b  2   ��  � ��$ Center=�5c  9   �� 5d  2    � ��
 ���� 5e  9   �� 5f  2    � {�$ False��5g  9   �� 5h  2    � ��$ 25��5i  9   �� 5j  2    � ��$ 20(�5k  9   5l  /   5n  '     5o  &   $	# 200 69   $ 5p  9   �� *Infomartion+% 5r  *   �� 5s  .   .R�5t  2   �� $��2,4,2,2q�6=   $& 
Horizontal=�5u  =   .+�5v  6   �� $' 0,0,5,5q�6@   $��25(�5w  @   $��Ghi chú��5x  @   5y  3   5z  /   ( 5|  *   �� 5}  .   $) Black��6>   * 5  *   �� 5�  .   " ��64   .�5�  2   ��  � ��$ Center=�5�  9   �� 5�  2    � ��$
 Wrap=�5�  9   6H   �� 5�  2    � ��
 ���� 5�  9   �� 5�  2    � {�$ False��5�  9   �� 5�  2    � ��$ 25��5�  9   �� 5�  2    � ��$ 20(�5�  9   5�  /   5�  '    5�  "     5�  &   $ SelectionChanged��65   . 5�  *   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  ,   Command, 6@   �� *SelectionCommand+5�  '   5�     5�     5�     5�     � 5�     $��1��6   
 5�     �� 5�     �� 5�     .+�5�     �� $	��200��6   $��80��5�     $��	100,0,0,0q�5�     $��30(�5�     #��[ 5�     ��5�     �� *PostServerExcel+.��5�  A   Hoàn Thành5�     �� 5�     $��1��6   $	��200��5�     $��80��5�     $��	0,0,100,0q�5�     $��30(�5�     #��[ 5�     ��5�     �� *ExcelExport+.��5�  A   Xuất Excel5�     5�     5�     � 5�     $��0��6    5�     �� 5�     $��9* �6$   �� 5�     $��1* �6$   .+�5�     � $��0��6   .+�5�     	  $	��400��6*   $	��480��5�  *   $��Center=�5�  *   $��Center=�5�  *   .��5�     �  5�     �� 5�  "   $
��auto �60   �� 5�  "   $��* �60   .+�5�     �� $��0��6)   .+�5�  "   �� $	��0,7q�6,   $��30(�5�  ,     PageModuleTitle#��[ 5�  ,   �� 5�  &   .�6+   Đơn Hiện Có Trong Ngày5�  '   5�  #   � 5�  "   $	��400��6'   $��8��5�  '   ���	#FF00294D5�  '   5�     � 5�     $��1��6#   $��Center=�5�  #   .+�5�  "   W   QWarehouseManagementDesktopApp.Resources.Components.Message.ChatMessageListControl  $	��422��6<   $��50,0,0,0q�5�  <   $
��Left=�5�  <   $	��Top=�5�  <   - � DataContext- 5�  <   �� *ChatMessageList+5�     5�     5�     5�     � 5�     $��1��6   .+�5�     �� $��1��6   $��Center=�5�     $��Center=�5�     
���   �$��0,1,1,1q�5�     #���  5�     ��5�     �� *ReloadCommand+.��5�       $��50��62   $��50��5�  2   $ Reload=�5�  2   $ 1Q�5�  2   5�     5�     5�     5�     5�     5�     