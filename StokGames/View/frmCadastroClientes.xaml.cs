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
    /// Lógica interna para frmCadastroClientes.xaml
    /// </summary>
    public partial class frmCadastroClientes : Window
    {
        private readonly ControleCliente controleCliente;

        public frmCadastroClientes()
        {
            InitializeComponent();
            controleCliente = new ControleCliente();
            AtualizarClientes();
            LimparCliente();
        }

        private void BtnVoltarCadCliente_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AtualizarClientes()
        {
            List<Cliente> clientes = controleCliente.ObterTodos();

            if (clientes != null)
                dtgClientes.ItemsSource = clientes;
        }
               
        private void LimparCliente()
        {
            txbCodCadCliente.Text = string.Empty;
            txbNomeCadCliente.Text = string.Empty;
            txbTelefoneCadCliente.Text = string.Empty;
            txbCpfCadCliente.Text = string.Empty;
            txbEmailCadCliente.Text = string.Empty;
            txbRuaCadCliente.Text = string.Empty;
            txbNumeroCadCliente.Text = string.Empty;
            txbBairroCadCliente.Text = string.Empty;
            txbCidadeCadCliente.Text = string.Empty;
            txbComplementoCadCliente.Text = string.Empty;
            txbUFCadCliente.Text = string.Empty;
        }
        
        private void BtnCadastrarCadCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txbNomeCadCliente.Text;
            cliente.Telefone = txbTelefoneCadCliente.Text;
            cliente.CPF = txbCpfCadCliente.Text;
            cliente.Email = txbEmailCadCliente.Text;
            Endereco endereco = new Endereco();
            endereco.Rua = txbRuaCadCliente.Text;
            endereco.Numero = Convert.ToInt32(txbNumeroCadCliente.Text);
            endereco.Bairro = txbBairroCadCliente.Text;
            endereco.Cidade = txbCidadeCadCliente.Text;
            endereco.Complemento = txbComplementoCadCliente.Text;
            endereco.UF = txbUFCadCliente.Text;
            cliente.Endereco = endereco;

            if (txbCodCadCliente.Text == string.Empty)
                controleCliente.CadastrarCliente(cliente);
            else
            {
                cliente.Id = Convert.ToInt32(txbCodCadCliente.Text);
                cliente.EnderecoId = Convert.ToInt32(txbEnderecoIdCadCliente.Text);
                controleCliente.EditarCliente(cliente);
            }

            MessageBox.Show(controleCliente.mensagem);

            if (controleCliente.sucesso)
            {
                AtualizarClientes();
                LimparCliente();
            }
            

            #region Anterior
            //Cliente cliente = new Cliente();
            //cliente.id_usuario = txbCodCadCliente.Text;
            //cliente.nome = txbNomeCadCliente.Text;
            //cliente.telefone = txbTelefoneCadCliente.Text;
            //cliente.cpf = txbCpfCadCliente.Text;
            //cliente.email = txbEmailCadCliente.Text;
            //cliente.rua = txbRuaCadCliente.Text;
            //cliente.bairro = txbBairroCadCliente.Text;
            //cliente.cidade = txbCidadeCadCliente.Text;
            //cliente.complemento = txbComplementoCadCliente.Text;
            //cliente.uf = txbUFCadCliente.Text;

            //Model.ControleCliente controleCliente = new Model.ControleCliente();
            //controleCliente.CadastrarCliente(cliente);
            //MessageBox.Show(controleCliente.mensagem);
            #endregion Anterior
        }

        private void BtnEditarCadCliente_Click(object sender, RoutedEventArgs e)
        {
            if (dtgClientes.SelectedItem != null)
            {
                Cliente cliente = (Cliente)dtgClientes.SelectedItem;
                txbCodCadCliente.Text = cliente.Id.ToString();
                txbNomeCadCliente.Text = cliente.Nome;
                txbTelefoneCadCliente.Text = cliente.Telefone;
                txbCpfCadCliente.Text = cliente.CPF;
                txbEmailCadCliente.Text = cliente.Email;
                txbEnderecoIdCadCliente.Text = cliente.EnderecoId.ToString();
                txbRuaCadCliente.Text = cliente.Endereco.Rua;
                txbNumeroCadCliente.Text = cliente.Endereco.Numero.ToString();
                txbBairroCadCliente.Text = cliente.Endereco.Bairro;
                txbCidadeCadCliente.Text = cliente.Endereco.Cidade;
                txbComplementoCadCliente.Text = cliente.Endereco.Complemento;
                txbUFCadCliente.Text = cliente.Endereco.UF;
            }
            else
                MessageBox.Show("Selecione um cliente.");


            #region Anterior
            //Cliente cliente = new Cliente();
            //cliente.id_usuario = txbCodCadCliente.Text;
            //cliente.nome = txbNomeCadCliente.Text;
            //cliente.telefone = txbTelefoneCadCliente.Text;
            //cliente.cpf = txbCpfCadCliente.Text;
            //cliente.email = txbEmailCadCliente.Text;
            //cliente.rua = txbRuaCadCliente.Text;
            //cliente.bairro = txbBairroCadCliente.Text;
            //cliente.cidade = txbCidadeCadCliente.Text;
            //cliente.complemento = txbComplementoCadCliente.Text;
            //cliente.uf = txbUFCadCliente.Text;

            //Model.ControleCliente controleCliente = new Model.ControleCliente();
            //controleCliente.EditarCliente(cliente);
            //MessageBox.Show(controleCliente.mensagem);
            #endregion Anterior

        }


        private void BtnExcluirCadCliente_Click(object sender, RoutedEventArgs e)
        {
            if (dtgClientes.SelectedItem != null)
            {
                Cliente cliente = (Cliente)dtgClientes.SelectedItem;
                controleCliente.ExcluirCliente(cliente.Id);
                MessageBox.Show(controleCliente.mensagem);

                if (controleCliente.sucesso)
                {
                    AtualizarClientes();
                    LimparCliente();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente.");
            }

            #region Anterior
            //Cliente cliente = new Cliente();
            //cliente.id_usuario = txbCodCadCliente.Text;
            //cliente.nome = txbNomeCadCliente.Text;
            //cliente.telefone = txbTelefoneCadCliente.Text;
            //cliente.cpf = txbCpfCadCliente.Text;
            //cliente.email = txbEmailCadCliente.Text;
            //cliente.rua = txbRuaCadCliente.Text;
            //cliente.bairro = txbBairroCadCliente.Text;
            //cliente.cidade = txbCidadeCadCliente.Text;
            //cliente.complemento = txbComplementoCadCliente.Text;
            //cliente.uf = txbUFCadCliente.Text;

            //Model.ControleCliente controleCliente = new Model.ControleCliente();

            //MessageBoxResult resultado = MessageBox.Show("Deseja realmente excluir?", "Alerta de exclusão", MessageBoxButton.YesNo,
            //    MessageBoxImage.Warning);

            //if (resultado == MessageBoxResult.Yes)
            //{
            //    ControleCliente.ExcluirCliente(cliente);
            //    MessageBox.Show(controleCliente.mensagem);
            //}
            #endregion Anterior

        }

        private void BtnLimparCadCliente_Click(object sender, RoutedEventArgs e)
        {
            LimparCliente();
        }


    }
}
