   M S B A M L   `   `   `  ����E  ADragablz, Version=0.0.3.234, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz  5   	   > :PDV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PDVPDV 5   	      PDV.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   7dragablz(clr-namespace:Dragablz;assembly=Dragablz  5   	   localclr-namespace:PDV  5   	     � Title$  
MainWindow��5
   	   $	��700��6   $
��1140��6)      MaterialDesignBody#���   5   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ��5   	   Z� .��5      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6     MaterialDesignPaper#���  63   $��25q�6f   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6r   .��5   
   �  � ColumnDefinitions 5      �� 5      $	��190 �6#   �� 5      $��* �6#   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6'   $	��650��67      CornerRadius$ 	15 0 0 15��6D   
�������.��5      �� $��15q�6   .+�5      � $��	0 15 5 60q�6    $��Center=�63   .+�5      ��  �� BitmapScalingMode$ HighQuality=�6    $M��GC:\OneDrive\Área de Trabalho\Balta\PDV\PDV\Recursos\IconeInlivePDV.png��6N   $��30��6�   $��30��6�   �� 5      $��	FTech PDV��6$   $��20(�65   $
��Bold"�6C   $
��Left=�6U   $��Center=�6p   $��10 0 0 0q�6�   5      �� 5      -   5        	 ��Name$	 btnVenda��5        MaterialDesignFlatButton#��[ 6/    " PrimaryHueLightForegroundBrush#���  6a   +  %MaterialDesignThemes.Wpf.ButtonAssist
   CornerRadius$
 6��6�   $
��auto��6�   $��35��6�   +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback
 �����$��0 0 0 15q�6  .��5       � $	��120��6$   .+�5!      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ShoppingCart=�66   $��Center=�6J   $��0 0 20 0q�6e   �� 5"      $��	Venda PDV��6(   5#      5$      �� 5&      -   5        $	 btnProdutos��5&      #��[ 62   #���  6d   $
 6��6�   $
��auto��6�   $��35��6�   
 �����$��0 0 0 15q�6  .��5'      � $	��120��6$   .+�5(        $ Shopping=�66   $��Center=�6F   $��0 0 20 0q�6a   �� 5)      $��Produtos��6(   5*      5+      �� 5-      -   5        $	 btnCadastros��5-      #��[ 63   #���  6e   $
 6��6�   $
��auto��6�   $��35��6�   
 �����$��0 0 0 15q�6  .��5.      � $	��120��6$   .+�5/        $ 	AddCircle=�66   $��Center=�6G   $��0 0 20 0q�6b   �� 50      $��	Cadastros��6(   51      52      �� 54      -   5        $	 btnFerramentas��54      #��[ 65   #���  6g   $
 6��6�   $
��auto��6�   $��35��6�   
 �����$��0 0 0 15q�6  .��55      � $	��120��6$   .+�56        $ Settings=�66   $��Center=�6F   $��0 0 20 0q�6a   �� 57      $��Ferramentas��6(   58      59      �� 5;      -   5        $	 
btnSuporte��5;      #��[ 61   #���  6c   $
 6��6�   $
��auto��6�   $��35��6�   
 �����$��0 0 0 15q�6  .��5<      � $	��120��6$   .+�5=        $ Support=�66   $��Center=�6E   $��0 0 20 0q�6`   �� 5>      $��Suporte��6(   5?      5@      �� 5B      -   5        $	 	btnLogout��5B      #��[ 60   #���  6b   $
 6��6�   $
��auto��6�   $��35��6�   
 �����$��0 0 0 15q�6  .��5C      � $	��120��6$   .+�5D        $ Logout=�66   $��Center=�6D   $��0 0 20 0q�6_   �� 5E      $��logout��6(   5F      5G      5H      5I      � 5K      .+�5L      �� -   5         ��Name$ txtDgProdutos��5L      $��Tabela de Produtos��63   $��1��6M   $��331,27,331,583q�6]    �� TextAlignment$ Center=�6u   $��24(�6�   $��DemiBold"�6�   $y�	Collapsed=�6�   &   System.Windows.Controls.DataGrid  5N      -   5          Name$ 
dgProdutos��5N      $��1��6/   $��10,80,10,10q�6?   $y�	Collapsed=�6T      AutoGenerateColumns$ False��6k      CanUserAddRows$ False��6�      
IsReadOnly$
 True��6�      CanUserResizeColumns$ False��6�   ���	#1FD0D0D0   Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Código��6-    	  
IsReadOnly$
 True��6_    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	 13*
 6q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *CodigoProduto+6q     5Q      $ Produto��6-   $
 True��6^   $	 40*
 6p    6>   �� *NomeProduto+6p   4  .System.Windows.Controls.DataGridTemplateColumn  5S      $ Preço��61   $	 14*
 6@      CellTemplate 5T      �� 5U   "   .R�5V   &   �� ��60   �� *Preco+ �� StringFormat$ {0:C}�� �� ConverterCulture$ pt-BR��5W   #   5Y        5[      $ 	Embalagem��6-   $
 True��6^   $	 17*
 6p    6@   �� *	Embalagem+6p     5\      $ Estoque��6-   $
 True��6Z   $	 15*
 6l    6>   �� *	Estoque+6l     5]      $ 
Fornecedor��6-   $
 True��6`   $	 20*
 6r    6A   �� *
Fornecedor+6r     5^      $ Adicionado Em��6-   $
 True��6�   $	 20*
 6�    6D   �� *DataAdicionado+$ {0:dd/MM/yyyy}��6�   5`      5a      � 5c      -	   5         �Name$ GridCadastroProduto��5c      .+�5d      �� -
   5        $ tituloCadastroDeProdutos��5d      $��Cadastrar Produto��6>   $ Center=�6W   $��24(�6n   $��DemiBold"�6|   $y�Visible=�6�   $��347,46,320,521q�6�   �� 5f      -   5         ��Name$ txtNomeProduto��5f   2   $��55,121,452,421q�6   $��16(�6J   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ * Nome do Produto��5g      $��2q�6M     MaterialDesignDivider#���  6a    ! MaterialDesignOutlinedTextBox#��[ 5h      �� 5j      -   5        $ txtPrecoProduto��5j   2   $��55,221,452,321q�6   $��16(�6K   $ * Preço��5k      $��2q�6C   #���  6W   #��[ 5l      �� 5n      -   5        $ txtEstoqueProduto��5n   2   $��487,221,21,321q�6   $��16(�6M   $ 	* Estoque��5o      $��2q�6E   #���  6Y   #��[ 5p      �� 5r      -   5        $ txtEmbalagemProduto��5r   2   $��487,121,20,421q�6   $��16(�6O   $ * Embalagem��5s      $��2q�6G   #���  6[   #��[ 5t      �� 5v      -   5         ��Name$ cmbFornecedor��5v      $��59��62   $��16(�6>   $��55,336,452,0q�6L   $	��Top=�6b   $��2q�6z   #���  5w       " MaterialDesignOutlinedComboBox#��[ 6Q   5x      �� 5z      -   5        $	 btnCadastrar��5z   0   $��714,536,20,10q�6   $��55��6G   $ Depth0=�6T   $
 10��6�   $��20(�6�   $��	Cadastrar��5{      ���	#FF18407C���	#FF18407C6\   �� 5}      -   5        $	 btnCancelar��5}   1   $��536,536,198,10q�6   $ Depth0=�6F   $��55��5~      $
 10��6%   $��20(�6S   $��Cancelar��5      ���	#FFE2574C���	#FFE2574C6[   5�      5�      5�      5�      