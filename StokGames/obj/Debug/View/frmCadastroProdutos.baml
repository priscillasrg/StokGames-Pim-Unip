   M S B A M L   `   `   `  ����D  @StokGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:StokGames.ViewStokGames.View  5   	   (    "StokGames.View.frmCadastroProdutos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:StokGames.View     5   	   -   5          �Name$  frmCadastroProdutos1��5   	    � Title$# Stok Games - Cadastro Produto��5   	   $	��678��6/   $	��800��6<    � WindowStartupLocation$ CenterScreen=�6H   .��5	      � .+�5
   
   �� $��346,10,349,533q�6   $.��(/StokGames;component/stok_games_logo.png��6(   $
��Fill=�6Z   �� 5   
   ���#DCDCDC$��1q�6'   $
��Left=�6;   $	��647��6V   $��	723,0,0,0q�6c   $	��Top=�6v   $��69��6�   ���#1919706�   �� 5   
   ���#DCDCDC$��1q�6'   $
��Left=�6;   $	��647��6V   $	��Top=�6c   $��69��6{   ���#1919706�   �� 5   
   -   5         ��Name$ txbCodCadProduto��5       �� 
IsReadOnly . $
��Left=�6>   $��22��6Y   $��101,191,0,0q�6e    �� TextWrapping$
 Wrap=�6z   $	��Top=�6�   $��99��6�   �� 5   
   -   5         ��Name$ stack��5      $
��Left=�6%   $	��241��6@   $��101,218,0,0q�6M   $	��Top=�6b   $	��628��6z   .+�5      �� -   5         ��Name$ lblNomeCadProduto��5      $��Nome* ��6/   $
��Left=�6@   $	��Top=�6[   $��55��6s   �� 5      -   5        $ txbNomeCadProduto��5      $
��Left=�61   $��24��6L   $��
0,0,-200,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��300��6�   �� 5      -   5        $ lblCategoriaCadProduto��5      $��
Categoria*��64   $��Right=�6I   $��104,-50,240,0q�6e   $	��Top=�6|   $��80��6�   �� 5      -   5        $ txbCategoriaCadProduto��5      $��Right=�66   $��24��6R   $��305,-24,30,0q�6^   $
 Wrap=�6t   $	��Top=�6�   $	��292��6�   �� 5      -   5        $ lblMarcaCadProduto��5      $��Marca*��60   $
��Left=�6A   $��3,0,0,0q�6\   $	��Top=�6m   $��52��6�   �� 5      -	   5        $ txbMarcaCadProduto��5      $
��Left=�62   $��24��6M   $��
0,0,-200,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��300��6�   �� 5      -
   5        $ lblModeloCadProduto��5      $��Modelo��61   $��Right=�6B   $��104,-50,270,0q�6^   $	��Top=�6u   �� 5      -   5        $ txbModeloCadProduto��5      $��Right=�63   $��24��6O   $��305,-24,30,0q�6[   $
 Wrap=�6q   $	��Top=�6�   $	��292��6�   �� 5      -   5        $ lblEstoqueCadProduto��5      $��Estoque��62   $
��Left=�6D   $��3,0,0,0q�6_   $	��Top=�6p   �� 5      -   5        $ txbEstoqueCadProduto��5      $
��Left=�64   $��24��6O   $��
0,0,-200,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��300��6�   �� 5      -   5        $ lblEstoqueMinCadProduto��5      $��Estoque Mínimo*��65   $��Right=�6O   $��104,-50,220,0q�6k   $	��Top=�6�    J� RenderTransformOrigin$ 0.444,1.269&�6�   �� 5      -   5        $ txbEstoqueMinCadProduto��5      $��Right=�67   $��24��6S   $��305,-24,30,0q�6_   $
 Wrap=�6u   $	��Top=�6�   $	��292��6�   �� 5       -   5        $ lblCustoCadProduto��5       $��Custo*��60   $
��Left=�6A   $��3,0,0,0q�6\   $	��Top=�6m   �� 5!      -   5        $ txbCustoCadProduto��5!      $
��Left=�62   $��24��6M   $��
0,0,-122,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��222��6�   �� 5"      -   5        $ lblPrecoCadProduto��5"      $��Preço*��60   $��Center=�6A   $��-300,-50,-175,0q�6^   $	��Top=�6w   $��48��6�   �� 5#      -   5        $ txbPrecoCadProduto��5#      $��Center=�62   $��24��6O   $��222,-24,248,0q�6[   $
 Wrap=�6r   $	��Top=�6�   $	��150��6�   �� 5$      -   5        $ lblSerialCadProduto��5$      $��Serial��61   $��Right=�6B   $��104,-50,205,0q�6^   $	��Top=�6u   �� 5%      -   5        $ txbSerialCadProduto��5%      $��Right=�63   $��24��6O   $��305,-24,42,0q�6[   $
 Wrap=�6q   $	��Top=�6�   $	��207��6�   5&      �� 5*   
   -   5        	 ��Name$	 btnCadastrarCadProduto��5*      $
��Left=�61   $��624,518,0,0q�6L   $	��Top=�6a   $��74��6y   $��37��6�   ���	#FFEEEEEE$��Salvar��6�   $ 
0.616,0.41&�6�   6�   &   System.Windows.Controls.DataGrid  5+   
   -   5        
  Name$
 
dtgProduto��5+      $
��Left=�6(   $	��158��6C   $��106,468,0,0q�6P   $	��Top=�6e   $	��499��6}      AutoGenerateColumns .     
IsReadOnly .    Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Id+  5.      $
 Nome��6%    63   �� *Nome+  5/      $ 	Categoria��6%    68   �� *Categoria.Nome+  50      $ Marca��6%    64   �� *
Marca.Nome+  51      $ Modelo��6%    65   �� *Modelo+  52      $ Estoque��6%    66   �� *	Estoque+  53      $ Preço��6%    64   �� *Preco+  54      $ Cadastro��6%    67   �� *
Insercao+  55      $ Última atualização��6%    6A   �� *UltimaAtualizacao+57      �� 58   
   -   5        $ txbCategoriaIdCadProduto��58      $y�Hidden=�65   $
��Left=�6I   $��23��6d   $��106,417,0,0q�6p   $��1��6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 59   
   -   5        $ txbMarcaIdCadProduto��59      $y�Hidden=�61   $
��Left=�6E   $��23��6`   $��106,417,0,0q�6l   $��1��6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5:   
   -   5        $	 btnLimparCadProduto��5:      $
��Left=�6.   $��467,162,0,0q�6I   $	��Top=�6^   $��74��6v   $��37��6�   ���	#FFEEEEEE$��Limpar��6�   6�   �� 5;   
   -   5        $	 btnExcluirCadProduto��5;      $
��Left=�6/   $��624,162,0,0q�6J   $	��Top=�6_   $��74��6w   $��37��6�   ���	#FFEEEEEE$��Excluir��6�   6�   �� 5<   
   -   5        $	 btnVoltarCadProduto��5<      $
��Left=�6.   $��101,106,0,0q�6I   $	��Top=�6^   $��74��6v   $��36��6�   ���	#FFEEEEEE$��Voltar��6�   $ 0.223,1.486&�6�   �� 5=   
   -   5        $	 btnEditarCadProduto��5=      $
��Left=�6.   $��546,162,0,0q�6I   $	��Top=�6^   $��74��6v   $��37��6�   ���	#FFEEEEEE$��Editar��6�   6�   5B      5C      