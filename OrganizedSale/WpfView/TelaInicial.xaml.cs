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

namespace WpfView
{
    /// <summary>
    /// Lógica interna para TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        public TelaInicial()
        {            
            InitializeComponent();
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }

        private void btnClickando(object sender, MouseButtonEventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.ShowDialog();
        }

        private void BemVindo(object sender, EventArgs e)
        {
            txtBemVindo.Content = "Seja Bem Vindo \n" + Controllers.Session.usuario.Nome.ToUpper();
        }
    }
}
