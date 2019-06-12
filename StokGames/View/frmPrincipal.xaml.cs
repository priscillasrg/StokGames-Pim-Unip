using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StokGames.View
{
    /// <summary>
    /// Lógica interna para frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void MniSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MniFuncionario_Click(object sender, RoutedEventArgs e)
        {
            View.frmCadastroFuncionarios frmCadFuncionarios = new View.frmCadastroFuncionarios();
            frmCadFuncionarios.ShowDialog();
        }

        private void MniCliente_Click(object sender, RoutedEventArgs e)
        {
            View.frmCadastroClientes frmCadClientes = new View.frmCadastroClientes();
            frmCadClientes.ShowDialog();
        }

        private void MniProduto_Click(object sender, RoutedEventArgs e)
        {
            View.frmCadastroProdutos frmCadProdutos = new View.frmCadastroProdutos();
            frmCadProdutos.ShowDialog();
        }
 
        private void MniFornecedor_Click(object sender, RoutedEventArgs e)
        {

            View.frmCadastroFornecedor frmCadFornecedor = new View.frmCadastroFornecedor();
            frmCadFornecedor.ShowDialog();
        }
    }
}
