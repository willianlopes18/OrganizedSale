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
    /// Lógica interna para EditarProduto.xaml
    /// </summary>
    public partial class EditarProduto : Window
    {
        public EditarProduto(int id)
        {
            InitializeComponent();

            ProdutosController controller = new ProdutosController();
            inputCodigoProduto.Text = Convert.ToString(id);
            inputCodigoProduto.IsEnabled = false;

            for (int i = 0; i < controller.ListarCategorias().Count; i++)
            {
                cbCategoria.Items.Add(controller.ListarCategorias()[i]);
            }
        }

        private void inputCodigo(object sender, TextChangedEventArgs e)
        {
            ProdutosController produtos = new ProdutosController();

            if (inputCodigoProduto.Text != "")
            {
                var codigo = Convert.ToInt32(inputCodigoProduto.Text);

                var produto = produtos.BuscarPorID(codigo);

                if (produto != null)
                {
                    cbCategoria.SelectedIndex = produto.CategoriaID -1;
                    txtMarca.Text = produto.Marca;
                    txtModelo.Text = produto.Modelo;
                    txtQuantidadeProduto.Text = Convert.ToString(produto.Quantidade);
                    txtValor.Text = Convert.ToString(produto.ValorCompra);
                    txtLucro.Text = Convert.ToString(produto.Lucro);
                }
                else
                {
                    cbCategoria.SelectedItem = "";
                }
            }
        }

        private void btnSalvar(object sender, RoutedEventArgs e)
        {
            try
            {
                Produto produto = new Produto();

                produto.ProdutoID = Convert.ToInt32(inputCodigoProduto.Text);
                produto.CategoriaID = cbCategoria.SelectedIndex + 1;
                produto.Marca = txtMarca.Text;
                produto.Modelo = txtModelo.Text;
                produto.ValorCompra = Convert.ToDouble(txtValor.Text);
                produto.Quantidade = Convert.ToInt32(txtQuantidadeProduto.Text);
                produto.Lucro = Convert.ToInt32(txtLucro.Text);

                ProdutosController editaProduto = new ProdutosController();
                editaProduto.Editar(produto);

                MessageBox.Show("Produto salvo com sucesso");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o produto(" + ex.Message + ")");

            }
        }
    }
}
