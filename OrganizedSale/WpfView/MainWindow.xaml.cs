using Controllers;
using System.Windows;

namespace WpfView
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
            InitializeComponent();
        }

        private void btnLogarSistema(object sender, RoutedEventArgs e)
        {            
            UsuariosController usuariosController = new UsuariosController();

            if (txtLoginCPF.Text.Equals("") || txtLoginCPF.Text == null || txtSenha.Password.Equals("") || txtSenha.Password == null)
            {
                MessageBox.Show("Preencha o usuário e Senha");
            }
            else
            {
                var Login = usuariosController.ValidarLogin(txtLoginCPF.Text, txtSenha.Password);

                if (Login == true)
                {                    
                    TelaInicial telaIni = new TelaInicial();
                    telaIni.Show();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido!");
                }
            }
            
        }
    }
}
