using StokGames.Controller;
using StokGames.Model;
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
    /// Lógica interna para frmCadastroFornecedor.xaml
    /// </summary>
    public partial class frmCadastroFornecedor : Window
    {
        private readonly ControleFornecedor controleFornecedor;
        public frmCadastroFornecedor()
        {
            InitializeComponent();
            controleFornecedor = new ControleFornecedor();
            AtualizarFornecedor();
            LimparFornecedor();
        }
        private void AtualizarFornecedor()
        {
            List<Fornecedor> fornecedor = controleFornecedor.ObterTodos();

            if (fornecedor != null)
                dtgFornecedor.ItemsSource = fornecedor;
        }

        private void LimparFornecedor()
        {
            txbCodCadFornecedor.Text = string.Empty;
            txbNomeCadFornecedor.Text = string.Empty;
            txbTelefoneCadFornecedor.Text = string.Empty;
            txbCnpjCadFornecedor.Text = string.Empty;
            txbEmailCadFornecedor.Text = string.Empty;
            txbRuaCadFornecedor.Text = string.Empty;
            txbNumeroCadFornecedor.Text = string.Empty;
            txbBairroCadFornecedor.Text = string.Empty;
            txbCidadeCadFornecedor.Text = string.Empty;
            txbComplementoCadFornecedor.Text = string.Empty;
            txbUFCadFornecedor.Text = string.Empty;
        }

        private void BtnVoltarCadFornecedor_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BtnCadastrarCadFornecedor_Click(object sender, RoutedEventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Nome = txbNomeCadFornecedor.Text;
            fornecedor.Telefone = txbTelefoneCadFornecedor.Text;
            fornecedor.CNPJ = txbCnpjCadFornecedor.Text;
            fornecedor.Email = txbEmailCadFornecedor.Text;
            Endereco endereco = new Endereco();
            endereco.Rua = txbRuaCadFornecedor.Text;
            endereco.Numero = Convert.ToInt32(txbNumeroCadFornecedor.Text);
            endereco.Bairro = txbBairroCadFornecedor.Text;
            endereco.Cidade = txbCidadeCadFornecedor.Text;
            endereco.Complemento = txbComplementoCadFornecedor.Text;
            endereco.UF = txbUFCadFornecedor.Text;
            fornecedor.Endereco = endereco;

            if (txbCodCadFornecedor.Text == string.Empty)
                controleFornecedor.CadastrarFornecedor(fornecedor);
            else
            {
                fornecedor.Id = Convert.ToInt32(txbCodCadFornecedor.Text);
                fornecedor.EnderecoId = Convert.ToInt32(txbEnderecoIdCadFornecedor.Text);
                controleFornecedor.EditarFornecedor(fornecedor);
            }

            MessageBox.Show(controleFornecedor.mensagem);

            if (controleFornecedor.sucesso)
            {
                AtualizarFornecedor();
                LimparFornecedor();
            }

            #region Anterior
            //Fornecedor fornecedor = new Fornecedor();
            //fornecedor.id_usuario = txbCodCadFornecedor.Text;
            //fornecedor.nome = txbNomeCadFornecedor.Text;
            //fornecedor.cnpj = txbCnpjCadFornecedor.Text;
            //fornecedor.rua = txbRuaCadFornecedor.Text;
            //fornecedor.bairro = txbBairroCadFornecedor.Text;
            //fornecedor.cidade = txbCidadeCadFornecedor.Text;
            //fornecedor.complemento = txbComplementoCadFornecedor.Text;
            //fornecedor.uf = txbUFCadFornecedor.Text;
            //fornecedor.telefone = txbTelefoneCadFornecedor.Text;
            //fornecedor.email = txbEmailCadFornecedor.Text;

            //Model.ControleFornecedor controleFornecedor = new Model.ControleFornecedor();
            //controleFornecedor.CadastrarFornecedor(fornecedor);
            //MessageBox.Show(controleFornecedor.mensagem);
            #endregion Anterior
        }


        private void BtnEditarCadFornecedor_Click(object sender, RoutedEventArgs e)
        {
            if (dtgFornecedor.SelectedItem != null)
            {
                Fornecedor fornecedor = (Fornecedor)dtgFornecedor.SelectedItem;
                txbCodCadFornecedor.Text = fornecedor.Id.ToString();
                txbNomeCadFornecedor.Text = fornecedor.Nome;
                txbTelefoneCadFornecedor.Text = fornecedor.Telefone;
                txbCnpjCadFornecedor.Text = fornecedor.CNPJ;
                txbEmailCadFornecedor.Text = fornecedor.Email;
                txbEnderecoIdCadFornecedor.Text = fornecedor.EnderecoId.ToString();
                txbRuaCadFornecedor.Text = fornecedor.Endereco.Rua;
                txbNumeroCadFornecedor.Text = fornecedor.Endereco.Numero.ToString();
                txbBairroCadFornecedor.Text = fornecedor.Endereco.Bairro;
                txbCidadeCadFornecedor.Text = fornecedor.Endereco.Cidade;
                txbComplementoCadFornecedor.Text = fornecedor.Endereco.Complemento;
                txbUFCadFornecedor.Text = fornecedor.Endereco.UF;
            }
            else
                MessageBox.Show("Selecione um fornecedor.");

            #region Anterior
            //fornecedor fornecedor = new fornecedor();
            //fornecedor.id_usuario = txbcodcadfornecedor.text;
            //fornecedor.nome = txbnomecadfornecedor.text;
            //fornecedor.cnpj = txbcnpjcadfornecedor.text;
            //fornecedor.rua = txbruacadfornecedor.text;
            //fornecedor.bairro = txbbairrocadfornecedor.text;
            //fornecedor.cidade = txbcidadecadfornecedor.text;
            //fornecedor.complemento = txbcomplementocadfornecedor.text;
            //fornecedor.uf = txbufcadfornecedor.text;
            //fornecedor.telefone = txbtelefonecadfornecedor.text;
            //fornecedor.email = txbemailcadfornecedor.text;

            //model.controlefornecedor controlefornecedor = new model.controlefornecedor();
            //controlefornecedor.editarfornecedor(fornecedor);
            //messagebox.show(controlefornecedor.mensagem);
            #endregion Anterior
        }



        private void BtnExcluirCadFornecedor_Click(object sender, RoutedEventArgs e)
        {
            if (dtgFornecedor.SelectedItem != null)
            {
                Fornecedor fornecedor = (Fornecedor)dtgFornecedor.SelectedItem;
                controleFornecedor.ExcluirFornecedor(fornecedor.Id);
                MessageBox.Show(controleFornecedor.mensagem);

                if (controleFornecedor.sucesso)
                {
                    AtualizarFornecedor();
                    LimparFornecedor();
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor.");
            }

            #region Anterior
            //Fornecedor fornecedor = new Fornecedor();
            //fornecedor.id_usuario = txbCodCadFornecedor.Text;
            //fornecedor.nome = txbNomeCadFornecedor.Text;
            //fornecedor.cnpj = txbCnpjCadFornecedor.Text;
            //fornecedor.rua = txbRuaCadFornecedor.Text;
            //fornecedor.bairro = txbBairroCadFornecedor.Text;
            //fornecedor.cidade = txbCidadeCadFornecedor.Text;
            //fornecedor.complemento = txbComplementoCadFornecedor.Text;
            //fornecedor.uf = txbUFCadFornecedor.Text;
            //fornecedor.telefone = txbTelefoneCadFornecedor.Text;
            //fornecedor.email = txbEmailCadFornecedor.Text;

            //Model.ControleFornecedor controleFornecedor = new Model.ControleFornecedor();

            //MessageBoxResult resultado = MessageBox.Show("Deseja realmente excluir?", "Alerta de exclusão", MessageBoxButton.YesNo,
            //    MessageBoxImage.Warning);

            //if (resultado == MessageBoxResult.Yes)
            //{
            //    ControleFornecedor.ExcluirFornecedor(fornecedor);
            //    MessageBox.Show(controleFornecedor.mensagem);
            //}
            #endregion Anterior
        }

        private void BtnLimparCadFornecedor_Click(object sender, RoutedEventArgs e)
        {
            LimparFornecedor();
        }
    }
}
