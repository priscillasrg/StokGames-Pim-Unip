   M S B A M L   `   `   `  ����D  @StokGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:StokGames.ViewStokGames.View  5   	   *    $StokGames.View.frmCadastroFornecedor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:StokGames.View     5   	   -   5          �Name$  frmCadastroFornecedor1��5   	    � Title$&  Stok Games - Cadastro Fornecedor��5   	   $	��678��62   $	��800��6?    � WindowStartupLocation$ CenterScreen=�6K   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��180* �6   �� 5      $
��467* �6   .+�5   
   �� -   5         ��Name$ txbCodCadFornecedor��5       �� 
IsReadOnly . $
��Left=�6A   $��22��6\   $��84,4,0,0q�6h    �� TextWrapping$
 Wrap=�6z   $	��Top=�6�   $	��108��6�   $��1��6�   �� 5   
   $��346,10,349,66q�6   $.��(/StokGames;component/stok_games_logo.png��6'   $
��Fill=�6Y   �� 5   
   ���#DCDCDC$��1q�6'   $
��Left=�6;   $	��647��6V   $��	723,0,0,0q�6c   $	��Top=�6v   $��69��6�   ���#191970$��2��6�   �� 5   
   ���#DCDCDC$��1q�6'   $
��Left=�6;   $	��647��6V   $	��Top=�6c   $��69��6{   ���#191970$��2��6�   �� 5   
   -   5         ��Name$ btnCadastrarCadFornecedor��5      $
��Left=�64   $��635,357,0,0q�6O   $	��Top=�6d   $��74��6|   $��37��6�   ���	#FFEEEEEE$��Salvar��6�   $��1��6�   �� 5   
   -   5         ��Name$ lblNomeCadFornecedor��5      $��Nome*��6.   $
��Left=�6>   $��	85,26,0,0q�6Y   $	��Top=�6l   $��1��6�   �� 5   
   -   5        $ txbNomeCadFornecedor��5      $
��Left=�60   $��22��6K   $��	84,58,0,0q�6W   $
 Wrap=�6j   $	��Top=�6~   $	��450��6�   $��1��6�   �� 5   
   -   5        $ lblCnpjCadFornecedor��5      $��CNPJ*��6.   $
��Left=�6>   $��
539,26,0,0q�6Y   $	��Top=�6m   	 J� RenderTransformOrigin$	 0.242,0.577&�6�   $��1��6�   �� 5   
   -   5        $ txbCnpjCadFornecedor��5      $
��Left=�60   $��22��6K   $��
539,58,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��179��6�   $��1��6�   �� 5   
   -   5        $ lblRuaCadFornecedor��5      $
��Rua*��6-   $
��Left=�6<   $��	84,82,0,0q�6W   $	��Top=�6j   $��1��6�   �� 5   
   -	   5        $ txbRuaCadFornecedor��5      $
��Left=�6/   $��24��6J   $��
84,114,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��450��6�   $��1��6�   �� 5   
   -
   5        $ lblBairroCadFornecedor��5      $��Bairro��60   $
��Left=�6A   $��538,139,0,0q�6\   $	��Top=�6q   $	 0.068,0.731&�6�   $��1��6�   �� 5   
   -   5        $ txbBairroCadFornecedor��5      $
��Left=�62   $��24��6M   $��538,165,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��180��6�   $	 0.5,0.5&�6�   $��1��6�   �� 5   
   -   5        $ btnExcluirCadFornecedor��5      $
��Left=�62   $��625,133,0,0q�6M   $	��Top=�6b   $��74��6z   $��37��6�   ���	#FFEEEEEE$��Excluir��6�   6�   �� 5   
   -   5        $ btnVoltarCadFornecedor��5      $
��Left=�61   $��	87,90,0,0q�6L   $	��Top=�6_   $��74��6w   $��38��6�   ���	#FFEEEEEE$��Voltar��6�   6�   �� 5   
   -   5        $ btnEditarCadFornecedor��5      $
��Left=�61   $��546,133,0,0q�6L   $	��Top=�6a   $��74��6y   $��37��6�   ���	#FFEEEEEE$��Editar��6�   6�   �� 5   
   -   5        $! lblComplementoCadFornecedor��5      $��Complemento��65   $
��Left=�6K   $��
85,139,0,0q�6f   $	��Top=�6z   $��1��6�   �� 5    
   -   5        $! txbComplementoCadFornecedor��5       $
��Left=�67   $��24��6R   $��
85,165,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $	��446��6�   $	 0.5,0.5&�6�   $��1��6�   �� 5!   
   -   5        $ lblCidadeCadFornecedor��5!      $��Cidade��60   $
��Left=�6A   $��
85,192,0,0q�6\   $	��Top=�6p   $	 0.255,0.577&�6�   $��1��6�   �� 5"   
   -   5        $ txbCidadeCadFornecedor��5"      $
��Left=�62   $��22��6M   $��
85,222,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��446��6�   $��1��6�   �� 5#   
   -   5        $ lblUFCadFornecedor��5#      $��UF��6,   $
��Left=�69   $��539,196,0,0q�6T   $	��Top=�6i   $	 -2.917,-1.654&�6�   $��1��6�   �� 5$   
   -   5        $ txbUFCadFornecedor��5$      $
��Left=�6.   $��22��6I   $��539,222,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��179��6�   $��1��6�   �� 5%   
   -   5        $ lblTelefoneCadFornecedor��5%      $��	Telefone*��62   $
��Left=�6F   $��539,246,0,0q�6a   $	��Top=�6v   $	 0.018,0.385&�6�   $��1��6�   �� 5&   
   -   5        $ txbTelefoneCadFornecedor��5&      $
��Left=�64   $��24��6O   $��539,276,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��179��6�   $��1��6�   �� 5'   
   -   5        $ lblEmailCadFornecedor��5'      $��E-mail��6/   $
��Left=�6@   $��
88,246,0,0q�6[   $	��Top=�6o   $��1��6�   �� 5(   
   -   5        $ txbEmailCadFornecedor��5(      $
��Left=�61   $��24��6L   $��
85,276,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��443��6�   $��1��6�   �� 5)   
   -   5        $ lblNumeroCadFornecedor��5)      $��Número*��60   $
��Left=�6B   $��
539,88,0,0q�6]   $	��Top=�6q   $	 -2.917,-1.654&�6�   $��1��6�   �� 5*   
   -   5        $ txbNumeroCadFornecedor��5*      $
��Left=�62   $��22��6M   $��539,114,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��179��6�   $��1��6�   &   System.Windows.Controls.DataGrid  5+   
   -   5        
  Name$
 dtgFornecedor��5+      $
��Left=�6*   $	��100��6E   $��
85,329,0,0q�6R   $��1��6f   $	��Top=�6s   $	��524��6�      AutoGenerateColumns .     
IsReadOnly .    Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Id+  5.      $
 Nome��6%    63   �� *Nome+  5/      $ Telefone��6%    67   �� *
Telefone+  50      $ E-mail��6%    65   �� *Email+  51      $
 CNPJ��6%    63   �� *CNPJ+  52      $ Cadastro��6%    67   �� *
Insercao+  53      $ Última atualização��6%    6A   �� *UltimaAtualizacao+55      �� 56   
   -   5        $  txbEnderecoIdCadFornecedor��56      $y�Hidden=�67   $
��Left=�6K   $��23��6f   $��106,417,0,0q�6r   $��1��6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 57   
   -   5        $ btnLimparCadFornecedor��57      $
��Left=�61   $��467,133,0,0q�6L   $	��Top=�6a   $��74��6y   $��37��6�   ���	#FFEEEEEE$��Limpar��6�   6�   58      59      