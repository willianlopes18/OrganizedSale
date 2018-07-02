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
    /// Lógica interna para CadastroProduto.xaml
    /// </summary>
    public partial class CadastroProduto : Window
    {
        public CadastroProduto()
        {
            InitializeComponent();

            ProdutosController controller = new ProdutosController();

            for (int i = 0; i < controller.ListarCategorias().Count; i++)
            {
                cbCategoria.Items.Add(controller.ListarCategorias()[i]);   
            }
        }

        private void btnCadatraProdutoEntrada(object sender, RoutedEventArgs e)
        {
            try
            {
                Produto produto = new Produto();

                produto.CategoriaID = cbCategoria.SelectedIndex + 1;
                produto.Marca = txtMarca.Text;
                produto.Modelo = txtModelo.Text;
                produto.ValorCompra = txtValor.Text;
                produto.Quantidade = Convert.ToInt32(txtQuantidadeProduto.Text);

                ProdutosController entradaProduto = new ProdutosController();
                entradaProduto.Adicionar(produto);

                MessageBox.Show("Produto cadastrado com sucesso");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o produto(" + ex.Message + ")");
                throw;
            }
        }
    }
}
