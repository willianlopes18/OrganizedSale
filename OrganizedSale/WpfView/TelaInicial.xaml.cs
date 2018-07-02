using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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

            switch (Controllers.Session.usuario.PermissaoID)
            {                
                case 1:
                    //Habilita o Cadastro de Usuário
                    btnCriarUsuario.Visibility      = Visibility.Visible;
                    txtCadastrarUsuario.Visibility  = Visibility.Visible;
                    break;

                default:
                    //Esconde o menu de cadastrar Usuário
                    btnCriarUsuario.Visibility      = Visibility.Collapsed;
                    txtCadastrarUsuario.Visibility  = Visibility.Collapsed;

                    //Esconde o menu de cadastrar produto
                    //btnCadastrarProduto.Visibility  = Visibility.Collapsed;
                    //txtCadastrarProduto.Visibility   = Visibility.Collapsed;

                    break;
            }
        }

        private void BemVindo(object sender, EventArgs e)
        {
            txtBemVindo.Content = "Seja Bem Vindo \n" + Controllers.Session.usuario.Nome.ToUpper();
        }

        private void btnCriaUsuarioE(object sender, MouseButtonEventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.ShowDialog();
        }
        

        private void btnSairSistema(object sender, RoutedEventArgs e)
        {
            
            MainWindow LoginSistema = new MainWindow();
            this.Close();
            LoginSistema.ShowDialog();            
        }

        private void btnCadastrarProdutoE(object sender, MouseButtonEventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.ShowDialog();
        }

        private void exibeProdutos(object sender, RoutedEventArgs e)
        {
            Vendas venda = new Vendas();

            venda.ShowDialog();
        }
    }
}
