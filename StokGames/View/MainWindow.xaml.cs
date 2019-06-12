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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StokGames
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogar_Click(object sender, RoutedEventArgs e)
        {                 
            MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButton.OK);
            View.frmPrincipal frmP = new View.frmPrincipal();
            frmP.ShowDialog();
            this.Close();            
        }
    }
}
