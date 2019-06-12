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
    /// Lógica interna para frmCadastroProdutos.xaml
    /// </summary>
    public partial class frmCadastroProdutos : Window
    {
        private readonly ControleProduto controleProduto;

        public frmCadastroProdutos()
        {
            InitializeComponent();
            controleProduto = new ControleProduto();
            AtualizarProduto();
            LimparProduto();
        }

        private void BtnVoltarCadProduto_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AtualizarProduto()
        {
            List<Produto> produto = controleProduto.ObterTodos();

            if (produto != null)
                dtgProduto.ItemsSource = produto;
        }

        private void LimparProduto()
        {
            txbCodCadProduto.Text = string.Empty;
            txbNomeCadProduto.Text = string.Empty;
            txbCategoriaCadProduto.Text = string.Empty;
            txbMarcaCadProduto.Text = string.Empty;
            txbModeloCadProduto.Text = string.Empty;
            txbEstoqueCadProduto.Text = string.Empty;
            txbEstoqueMinCadProduto.Text = string.Empty;
            txbCustoCadProduto.Text = string.Empty;
            txbPrecoCadProduto.Text = string.Empty;
            txbSerialCadProduto.Text = string.Empty;            
        }
               

       
        private void BtnCadastrarCadProduto_Click(object sender, RoutedEventArgs e)
        {
            
            Produto produto = new Produto();
            produto.Nome = txbNomeCadProduto.Text;
            produto.Modelo = txbModeloCadProduto.Text;           
            produto.Serial = txbSerialCadProduto.Text;         
            
            Categoria categoria = new Categoria();
            categoria.Nome = txbCategoriaCadProduto.Text;
            produto.Categoria = categoria;

            Marca marca = new Marca();
            marca.Nome = txbMarcaCadProduto.Text;
            produto.Marca = marca;


            bool todosOsTextBoxEstaoPreenchidos = true;

            foreach (var child in this.stack.Children)
            {
                var textBox = child as TextBox;

                if (textBox != null && string.IsNullOrEmpty((child as TextBox).Text))
                {
                    todosOsTextBoxEstaoPreenchidos = false;
                    break;
                }
            }

            if (todosOsTextBoxEstaoPreenchidos)
            {
                MessageBox.Show("Campo preenchidos com sucesso");
            }

            else
            {
                MessageBox.Show("Campo obrigatório (*) sem preenchimento");
                controleProduto.EditarProduto(produto);

            }

            produto.Estoque = Convert.ToInt32(txbEstoqueCadProduto.Text);
            produto.EstoqueMinimo = Convert.ToInt32(txbEstoqueMinCadProduto.Text);
            produto.Custo = Convert.ToDecimal(txbCustoCadProduto.Text);
            produto.Preco = Convert.ToDecimal(txbPrecoCadProduto.Text);


            if (txbCodCadProduto.Text == string.Empty)
            {
                controleProduto.CadastrarProduto(produto);
            }
            else
            {
                produto.Id = Convert.ToInt32(txbCodCadProduto.Text);
                produto.CategoriaId = Convert.ToInt32(txbCategoriaIdCadProduto.Text);
                produto.MarcaId = Convert.ToInt32(txbMarcaIdCadProduto.Text);
                controleProduto.EditarProduto(produto);
            }                             

            
            MessageBox.Show(controleProduto.mensagem);

            if (controleProduto.sucesso)
            {
                AtualizarProduto();
                LimparProduto();
            }

            #region Anterior    
            //Produto produto = new Produto();
            //Produto.id_usuario = txbCodCadProduto.Text;
            //produto.nome = txbNomeCadProduto.Text;
            //produto.categoria = txbCategoriaCadProduto.Text;
            //produto.marca = txbMarcaCadProduto.Text;
            //produto.modelo = txbModeloCadProduto.Text;
            //produto.estoque = txbEstoqueCadProduto.Text;
            //produto.estoqueMinimo = txbEstoqueMinCadProduto.Text;
            //produto.custo = txbCustoCadProduto.Text;
            //produto.preco = txbPrecoCadProduto.Text;
            //produto.serial = txbSerialCadProduto.Text;

            //Model.ControleProduto controleProduto = new Model.ControleProduto();
            //controleProduto.CadastrarProduto(produto);
            //MessageBox.Show(controleProduto.mensagem);
            #endregion

        }

        private void BtnEditarCadProduto_Click(object sender, RoutedEventArgs e)
        {
            if (dtgProduto.SelectedItem != null)
            {
                Produto produto = (Produto)dtgProduto.SelectedItem;
                txbCodCadProduto.Text = produto.Id.ToString();
                txbNomeCadProduto.Text = produto.Nome;
                txbModeloCadProduto.Text = produto.Modelo;
                txbEstoqueCadProduto.Text = produto.Estoque.ToString();
                txbEstoqueMinCadProduto.Text = produto.EstoqueMinimo.ToString();
                txbCustoCadProduto.Text = produto.Custo.ToString();
                txbPrecoCadProduto.Text = produto.Preco.ToString();
                txbSerialCadProduto.Text = produto.Serial;
                txbMarcaCadProduto.Text = produto.Marca.Nome;
                txbCategoriaCadProduto.Text = produto.Categoria.Nome;
                txbCategoriaIdCadProduto.Text = produto.CategoriaId.ToString();
                txbMarcaIdCadProduto.Text = produto.MarcaId.ToString();
            }
            else
                MessageBox.Show("Selecione um Produto.");

            #region Anterior
            //Produto produto = new Produto();
            //Produto.id_usuario = txbCodCadProduto.Text;
            //produto.nome = txbNomeCadProduto.Text;
            //produto.categoria = txbCategoriaCadProduto.Text;
            //produto.marca = txbMarcaCadProduto.Text;
            //produto.modelo = txbModeloCadProduto.Text;
            //produto.estoque = txbEstoqueCadProduto.Text;
            //produto.estoqueMinimo = txbEstoqueMinCadProduto.Text;
            //produto.custo = txbCustoCadProduto.Text;
            //produto.preco = txbPrecoCadProduto.Text;
            //produto.serial = txbSerialCadProduto.Text;

            //Model.ControleProduto controleProduto = new Model.ControleProduto();
            //controleProduto.EditarProduto(produto);
            //MessageBox.Show(controleProduto.mensagem);
            #endregion
        }

        private void BtnExcluirCadProduto_Click(object sender, RoutedEventArgs e)
        {
            if (dtgProduto.SelectedItem != null)
            {
                Produto produto = (Produto)dtgProduto.SelectedItem;
                controleProduto.ExcluirProduto(produto.Id);
                MessageBox.Show(controleProduto.mensagem);

                if (controleProduto.sucesso)
                {
                    AtualizarProduto();
                    LimparProduto();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Produto.");
            }

            #region Anterior
            //Produto produto = new Produto();
            //Produto.id_usuario = txbCodCadProduto.Text;
            //produto.nome = txbNomeCadProduto.Text;
            //produto.categoria = txbCategoriaCadProduto.Text;
            //produto.marca = txbMarcaCadProduto.Text;
            //produto.modelo = txbModeloCadProduto.Text;
            //produto.estoque = txbEstoqueCadProduto.Text;
            //produto.estoqueMinimo = txbEstoqueMinCadProduto.Text;
            //produto.custo = txbCustoCadProduto.Text;
            //produto.preco = txbPrecoCadProduto.Text;
            //produto.serial = txbSerialCadProduto.Text;

            //Model.ControleProduto controleProduto = new Model.ControleProduto();

            //MessageBoxResult resultado = MessageBox.Show("Deseja realmente excluir?", "Alerta de exclusão", MessageBoxButton.YesNo,
            //    MessageBoxImage.Warning);

            //if (resultado == MessageBoxResult.Yes)
            //{
            //    ControleProduto.ExcluirProduto(produto);
            //    MessageBox.Show(controleProduto.mensagem);
            //}
            #endregion 

        }

        private void BtnLimparCadProduto_Click(object sender, RoutedEventArgs e)
        {
            LimparProduto();
        }

        private void Validar_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
