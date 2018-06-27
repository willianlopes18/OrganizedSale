using Controllers;
using Modelos;
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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class CadastroUsuario : Window
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnCadastrarUsuario(object sender, RoutedEventArgs e)
        {
            try
            {
                Usuario user = new Usuario();

                user.Nome           = txtNome.Text;
                user.Cpf            = txtCPF.Text;
                user.DataNascimento = txtDataNascimento.DisplayDate;
                user.Senha          = txtSenha.Password;

                UsuariosController usuariosController = new UsuariosController();
                usuariosController.Adicionar(user);

                MessageBox.Show("Usuário cadastrado com sucesso!");

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o usuário(" + ex.Message + ")");
            }
        }

        private void BtnCancelarCadastroUsuario(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtSenha_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }
    }
}
