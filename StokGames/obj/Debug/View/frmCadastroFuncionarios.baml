   M S B A M L   `   `   `  ����D  @StokGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:StokGames.ViewStokGames.View  5   	   ,    &StokGames.View.frmCadastroFuncionarios   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:StokGames.View     5   	   -   5          �Name$  frmCadastroFuncionarios1��5   	    � Title$( "Stok Games - Cadastro Funcionário��5   	   $	��678��63   $	��800��6@    � WindowStartupLocation$ CenterScreen=�6L   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��40* �6   �� 5      $	��81* �6   �� 5      $
��526* �6   .+�5   
   �� $��346,10,349,13q�6   $.��(/StokGames;component/stok_games_logo.png��6'   $
��Fill=�6Y   $��2��6h   �� 5   
   ���#DCDCDC$��1q�6'   $
��Left=�6;   $	��647��6V   $��	723,0,0,0q�6c   $	��Top=�6v   $��69��6�   ���#191970$��3��6�   �� 5   
   ���#DCDCDC$��1q�6'   $
��Left=�6;   $	��647��6V   $	��Top=�6c   $��69��6{   ���#191970$��3��6�   �� 5   
   -   5         ��Name$  btnCadastrarCadFuncionario��5      $
��Left=�65   $��619,426,0,0q�6P   $	��Top=�6e   $��74��6}   $��37��6�   ���	#FFEEEEEE$��Salvar��6�   $��2��6�   �� 5   
   -   5        $ btnExcluirCadFuncionario��5      $
��Left=�63   $��	642,0,0,0q�6N   $	��Top=�6a   $��74��6y   $��37��6�   ���	#FFEEEEEE$��Excluir��6�   $��2��6�   �� 5   
   -   5        $ btnVoltarCadFuncionario��5      $
��Left=�62   $��	86,20,0,0q�6M   $	��Top=�6`   $��74��6x   $��37��6�   ���	#FFEEEEEE$��Voltar��6�   $��1��6�   �� 5   
   -   5        $ btnEditarCadFuncionario��5      $
��Left=�62   $��	563,0,0,0q�6M   $	��Top=�6`   $��74��6x   $��37��6�   ���	#FFEEEEEE$��Editar��6�   $��2��6�   �� 5   
   -   5         ��Name$ txbCodCadFuncionario��5       �� 
IsReadOnly . $
��Left=�6B   $��22��6]   $��	82,26,0,0q�6i    �� TextWrapping$
 Wrap=�6|   $	��Top=�6�   $	��108��6�   $��2��6�   �� 5   
   -   5         ��Name$ lblNomeCadFuncionario��5      $��Nome*��6/   $
��Left=�6?   $��	82,48,0,0q�6Z   $	��Top=�6m   $��2��6�   $��26��6�   $��48��6�   �� 5   
   -   5        $ txbNomeCadFuncionario��5      $
��Left=�61   $��22��6L   $��	82,74,0,0q�6X   $
 Wrap=�6k   $	��Top=�6   $	��450��6�   $��2��6�   �� 5   
   -	   5        $ lblCpfCadFuncionario��5      $
��CPF*��6.   $
��Left=�6=   $��
537,48,0,0q�6X   $	��Top=�6l   	 J� RenderTransformOrigin$	 0.242,0.577&�6�   $��2��6�   $��26��6�   $��35��6�   �� 5   
   -
   5        $ txbCpfCadFuncionario��5      $
��Left=�60   $��22��6K   $��
537,74,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��179��6�   $��2��6�   �� 5   
   -   5        $ lblRuaCadFuncionario��5      $
��Rua*��6.   $
��Left=�6=   $��
83,101,0,0q�6X   $	��Top=�6l   $��2��6�   $��26��6�   $��43��6�   �� 5   
   -   5        $ txbRuaCadFuncionario��5      $
��Left=�60   $��24��6K   $��
82,125,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��450��6�   $��2��6�   �� 5   
   -   5        $ lblBairroCadFuncionario��5      $��Bairro��61   $
��Left=�6B   $��537,207,0,0q�6]   $	��Top=�6r   $	 0.068,0.731&�6�   $��2��6�   $��26��6�   $��41��6�   �� 5   
   -   5        $ txbBairroCadFuncionario��5      $
��Left=�63   $��24��6N   $��537,234,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��179��6�   $	 0.5,0.5&�6�   $��2��6�   �� 5    
   -   5        $" lblComplementoCadFuncionario��5       $��Complemento��66   $
��Left=�6L   $��
83,208,0,0q�6g   $	��Top=�6{   $��2��6�   $��26��6�   $��86��6�   �� 5!   
   -   5        $" txbComplementoCadFuncionario��5!      $
��Left=�68   $��24��6S   $��
83,234,0,0q�6_   $
 Wrap=�6s   $	��Top=�6�   $	��449��6�   $	 0.5,0.5&�6�   $��2��6�   �� 5"   
   -   5        $ lblCidadeCadFuncionario��5"      $��Cidade��61   $
��Left=�6B   $��
83,155,0,0q�6]   $	��Top=�6q   $	 0.255,0.577&�6�   $��2��6�   $��26��6�   $��47��6�   �� 5#   
   -   5        $ txbCidadeCadFuncionario��5#      $
��Left=�63   $��22��6N   $��
83,181,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��449��6�   $��2��6�   �� 5$   
   -   5        $ lblUFCadFuncionario��5$      $	��UF*��6-   $
��Left=�6;   $��537,155,0,0q�6V   $	��Top=�6k   $	 -2.917,-1.654&�6�   $��2��6�   $��26��6�   $��29��6�   �� 5%   
   -   5        $ txbUFCadFuncionario��5%      $
��Left=�6/   $��22��6J   $��537,181,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��179��6�   $��2��6�   �� 5&   
   -   5        $ lblTelefoneCadFuncionario��5&      $��	Telefone*��63   $
��Left=�6G   $��537,263,0,0q�6b   $	��Top=�6w   $	 0.018,0.385&�6�   $��2��6�   $��26��6�   $��59��6�   �� 5'   
   -   5        $ txbTelefoneCadFuncionario��5'      $
��Left=�65   $��24��6P   $��537,293,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��179��6�   $��2��6�   �� 5(   
   -   5        $ lblEmailCadFuncionario��5(      $��E-mail*��60   $
��Left=�6B   $��
83,267,0,0q�6]   $	��Top=�6q   $��2��6�   $��26��6�   $��48��6�   �� 5)   
   -   5        $ txbEmailCadFuncionario��5)      $
��Left=�62   $��24��6M   $��
83,293,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��443��6�   $��2��6�   �� 5*   
   -   5        $ lblNumeroCadFuncionario��5*      $��Número*��61   $
��Left=�6C   $��
537,99,0,0q�6^   $	��Top=�6r   $	 -2.917,-1.654&�6�   $��2��6�   $��26��6�   $��59��6�   �� 5+   
   -   5        $ txbNumeroCadFuncionario��5+      $
��Left=�63   $��22��6N   $��537,125,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��179��6�   $��2��6�   �� 5,   
   -   5        $ lblLoginCadFuncionario��5,      $��Login* ��60   $
��Left=�6B   $��
86,331,0,0q�6]   $	��Top=�6q   $	 0.018,0.385&�6�   $��2��6�   $��26��6�   $��44��6�   �� 5-   
   -   5        $ txbLoginCadFuncionario��5-      $
��Left=�62   $��24��6M   $��130,331,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��129��6�   $��2��6�   �� 5.   
   -   5        $ lblSenhaCadFuncionario��5.      $��Senha* ��60   $
��Left=�6B   $��259,331,0,0q�6]   $	��Top=�6r   $	 0.018,0.385&�6�   $��2��6�   $��26��6�   $��53��6�   �� 5/   
   -   5        $ txbSenhaCadFuncionario��5/      $
��Left=�62   $��24��6M   $��306,331,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��124��6�   $��2��6�   �� 50   
   -   5        $" lblTipoUsuarioCadFuncionario��50      $��Tipo usuário*��66   $
��Left=�6N   $��451,360,0,0q�6i   $	��Top=�6~   $	 0.018,0.385&�6�   $��2��6�   $��26��6�   $��81��6�   �� 51   
   -    5        $" txbTipoUsuarioCadFuncionario��51      $
��Left=�68   $��24��6S   $��537,362,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��179��6�   $��2��6�   �� 52   
   -!   5        $% lblConfirmarSenhaCadFuncionario��52      $��Confirmar senha*��69   $
��Left=�6T   $��435,329,0,0q�6o   $	��Top=�6�   $	 0.018,0.385&�6�   $��2��6�   $��26��6�   $	��102��6�   �� 53   
   -"   5        $% txbConfirmarSenhaCadFuncionario��53      $
��Left=�6;   $��24��6V   $��537,331,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��179��6�   $��2��6�   &   System.Windows.Controls.DataGrid  54   
   -#   5        
  Name$
 dtgFuncionarios��54      $
��Left=�6-   $	��100��6H   $��
89,399,0,0q�6U   $��2��6i   $	��Top=�6v   $	��489��6�      AutoGenerateColumns .     
IsReadOnly .    Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Id+  57      $
 Nome��6%    63   �� *Nome+  58      $ Telefone��6%    67   �� *
Telefone+  59      $ E-mail��6%    65   �� *Email+  5:      $	 CPF��6%    62   �� *CPF+  5;      $ Cadastro��6%    67   �� *
Insercao+  5<      $ Última atualização��6%    6A   �� *UltimaAtualizacao+5>      �� 5?   
   -$   5        $! txbEnderecoIdCadFuncionario��5?      $y�Hidden=�69   $
��Left=�6M   $��23��6h   $��596,493,0,0q�6t   $��2��6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5@   
   -%   5        $ btnLimparCadFuncionario��5@      $
��Left=�62   $��	484,0,0,0q�6M   $	��Top=�6`   $��74��6x   $��37��6�   ���	#FFEEEEEE$��Limpar��6�   $��2��6�   6�   5B      5C      