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
    /// Lógica interna para Vendas.xaml
    /// </summary>
    public partial class Vendas : Window
    {
        public Vendas()
        {
            InitializeComponent();
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
                    txtVendasProduto.Content = produto.Modelo;
                    var valor = Convert.ToDouble(produto.Lucro);
                    txtVendasValor.Content = ((valor/100) * produto.ValorCompra) + produto.ValorCompra;
                }
                else
                {
                    txtVendasProduto.Content = "";
                    txtVendasValor.Content = "";
                }
            }
            else
            {
                txtVendasProduto.Content = "";
                txtVendasValor.Content = "";
            }
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProdutosController venda = new ProdutosController();
            Produto produto = new Produto();

            produto.Quantidade = Convert.ToInt32(qtdCompra.Text);

            venda.Editar(produto);
        }
    }
}
