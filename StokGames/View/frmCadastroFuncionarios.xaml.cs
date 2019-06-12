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
    /// Lógica interna para frmCadastroFuncionarios.xaml
    /// </summary>
    public partial class frmCadastroFuncionarios : Window
    {
        private readonly ControleFuncionario controleFuncionario;
        public frmCadastroFuncionarios()
        {
            InitializeComponent();
            controleFuncionario = new ControleFuncionario();
            AtualizarFuncionario();
            LimparFuncionario();
        }

        private void BtnVoltarCadFuncionarios_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AtualizarFuncionario()
        {
            List<Funcionario> funcionario = controleFuncionario.ObterTodos();

            if (funcionario != null)
                dtgFuncionarios.ItemsSource = funcionario;
        }

        private void LimparFuncionario()
        {
            txbCodCadFuncionario.Text = string.Empty;
            txbNomeCadFuncionario.Text = string.Empty;
            txbTelefoneCadFuncionario.Text = string.Empty;
            txbCpfCadFuncionario.Text = string.Empty;
            txbEmailCadFuncionario.Text = string.Empty;
            txbRuaCadFuncionario.Text = string.Empty;
            txbNumeroCadFuncionario.Text = string.Empty;
            txbBairroCadFuncionario.Text = string.Empty;
            txbCidadeCadFuncionario.Text = string.Empty;
            txbComplementoCadFuncionario.Text = string.Empty;
            txbUFCadFuncionario.Text = string.Empty;

            //txbLoginCadFuncionario.Text = string.Empty;
            //txbSenhaCadFuncionario.Text = string.Empty;
            //txbConfirmarSenhaCadFuncionario.Text = string.Empty;
            //txbTipoUsuarioCadFuncionario.Text = string.Empty;
        }
           

        private void BtnCadastrarCadFuncionario_Click(object sender, RoutedEventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txbNomeCadFuncionario.Text;
            funcionario.Telefone = txbTelefoneCadFuncionario.Text;
            funcionario.CPF = txbCpfCadFuncionario.Text;
            funcionario.Email = txbEmailCadFuncionario.Text;

            Endereco endereco = new Endereco();
            endereco.Rua = txbRuaCadFuncionario.Text;
            endereco.Numero = Convert.ToInt32(txbNumeroCadFuncionario.Text);
            endereco.Bairro = txbBairroCadFuncionario.Text;
            endereco.Cidade = txbCidadeCadFuncionario.Text;
            endereco.Complemento = txbComplementoCadFuncionario.Text;
            endereco.UF = txbUFCadFuncionario.Text;
            funcionario.Endereco = endereco;

            if (txbCodCadFuncionario.Text == string.Empty)
                controleFuncionario.CadastrarFuncionario(funcionario);
            else
            {
                funcionario.Id = Convert.ToInt32(txbCodCadFuncionario.Text);
                funcionario.EnderecoId = Convert.ToInt32(txbEnderecoIdCadFuncionario.Text);
                controleFuncionario.EditarFuncionario(funcionario);
            }

            MessageBox.Show(controleFuncionario.mensagem);

            if (controleFuncionario.sucesso)
            {
                AtualizarFuncionario();
                LimparFuncionario();
            }

            #region Anterior
            //Funcionario funcionario = new Funcionario();
            //funcionario.id_usuario = txbCodCadFuncionario.Text;
            //funcionario.nome = txbNomeCadFuncionario.Text;
            //funcionario.cpf = txbCpfCadFuncionario.Text;
            //funcionario.rua = txbRuaCadFuncionario.Text;
            //funcionario.bairro = txbBairroCadFuncionario.Text;
            //funcionario.cidade = txbCidadeCadFuncionario.Text;
            //funcionario.complemento = txbComplementoCadFuncionario.Text;
            //funcionario.uf = txbUFCadFuncionario.Text;
            //funcionario.telefone = txbTelefoneCadFuncionario.Text;
            //funcionario.email = txbEmailCadFuncionario.Text;
            //funcionario.login = txbLoginCadFuncionario.Text;
            //funcionario.tipo = txbTipoUsuarioCadFuncionario.Text;
            //funcionario.senha = txbSenhaCadFuncionario.Text;
            //funcionario.confirmarSenha = txbConfirmarSenhaCadFuncionario.Text;

            //Model.ControleFuncionarios controleFuncionario = new Model.ControleFuncionarios();
            //controleFuncionario.CadastrarFuncionario(funcionario);
            //MessageBox.Show(controleFuncionario.mensagem);
            #endregion Anterior
        }

       

        private void BtnEditarCadFuncionario_Click(object sender, RoutedEventArgs e)
        {
            if (dtgFuncionarios.SelectedItem != null)
            {
                Funcionario funcionario = (Funcionario)dtgFuncionarios.SelectedItem;
                txbCodCadFuncionario.Text = funcionario.Id.ToString();
                txbNomeCadFuncionario.Text = funcionario.Nome;
                txbTelefoneCadFuncionario.Text = funcionario.Telefone;
                txbCpfCadFuncionario.Text = funcionario.CPF;
                txbEmailCadFuncionario.Text = funcionario.Email;
                txbEnderecoIdCadFuncionario.Text = funcionario.EnderecoId.ToString();
                txbRuaCadFuncionario.Text = funcionario.Endereco.Rua;
                txbNumeroCadFuncionario.Text = funcionario.Endereco.Numero.ToString();
                txbBairroCadFuncionario.Text = funcionario.Endereco.Bairro;
                txbCidadeCadFuncionario.Text = funcionario.Endereco.Cidade;
                txbComplementoCadFuncionario.Text = funcionario.Endereco.Complemento;
                txbUFCadFuncionario.Text = funcionario.Endereco.UF;
            }
            else
                MessageBox.Show("Selecione um funcionario.");

            #region Anterior
            //Funcionario funcionario = new Funcionario();     
            //funcionario.nome = txbNomeCadFuncionario.Text;
            //funcionario.cpf = txbCpfCadFuncionario.Text;
            //funcionario.rua = txbRuaCadFuncionario.Text;
            //funcionario.bairro = txbBairroCadFuncionario.Text;
            //funcionario.cidade = txbCidadeCadFuncionario.Text;
            //funcionario.complemento = txbComplementoCadFuncionario.Text;
            //funcionario.uf = txbUFCadFuncionario.Text;
            //funcionario.telefone = txbTelefoneCadFuncionario.Text;
            //funcionario.email = txbEmailCadFuncionario.Text;
            //funcionario.login = txbLoginCadFuncionario.Text;
            //funcionario.tipo = txbTipoUsuarioCadFuncionario.Text;
            //funcionario.senha = txbSenhaCadFuncionario.Text;
            //funcionario.confirmarSenha = txbConfirmarSenhaCadFuncionario.Text;

            //Model.ControleFuncionarios controleFuncionario = new Model.ControleFuncionarios();
            //controleFuncionario.EditarFuncionario(funcionario);
            //MessageBox.Show(controleFuncionario.mensagem);
            #endregion
        }

        private void BtnExcluirCadFuncionario_Click(object sender, RoutedEventArgs e)
        {

            if (dtgFuncionarios.SelectedItem != null)
            {
                Funcionario funcionario = (Funcionario)dtgFuncionarios.SelectedItem;
                controleFuncionario.ExcluirFuncionario(funcionario.Id);
                MessageBox.Show(controleFuncionario.mensagem);

                if (controleFuncionario.sucesso)
                {
                    AtualizarFuncionario();
                    LimparFuncionario();
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionario.");
            }

            #region Anterior
            //    Funcionario funcionario = new Funcionario();
            //    funcionario.id_usuario = txbCodCadFuncionario.Text;
            //    funcionario.nome = txbNomeCadFuncionario.Text;
            //    funcionario.cpf = txbCpfCadFuncionario.Text;
            //    funcionario.rua = txbRuaCadFuncionario.Text;
            //    funcionario.bairro = txbBairroCadFuncionario.Text;
            //    funcionario.cidade = txbCidadeCadFuncionario.Text;
            //    funcionario.complemento = txbComplementoCadFuncionario.Text;
            //    funcionario.uf = txbUFCadFuncionario.Text;
            //    funcionario.telefone = txbTelefoneCadFuncionario.Text;
            //    funcionario.email = txbEmailCadFuncionario.Text;
            //    funcionario.login = txbLoginCadFuncionario.Text;
            //    funcionario.tipo = txbTipoUsuarioCadFuncionario.Text;
            //    funcionario.senha = txbSenhaCadFuncionario.Text;
            //    funcionario.confirmarSenha = txbConfirmarSenhaCadFuncionario.Text;

            //    Model.ControleFuncionarios controleFuncionario = new Model.ControleFuncionarios();

            //    MessageBoxResult resultado = MessageBox.Show("Deseja realmente excluir?", "Alerta de exclusão", MessageBoxButton.YesNo,
            //        MessageBoxImage.Warning);

            //    if (resultado == MessageBoxResult.Yes)
            //    {
            //        ControleFuncionario.ExcluirFuncionario(funcionario);
            //        MessageBox.Show(controleFuncionario.mensagem);
            //    }
            #endregion

        }

        private void BtnLimparCadFuncionario_Click(object sender, RoutedEventArgs e)
        {
            LimparFuncionario();
        }
    }
}
