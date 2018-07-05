using Controllers;
using Modelos;
using System;
using System.Windows;
using System.Windows.Controls;

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
                    var valorVenda = ((valor / 100) * produto.ValorCompra) + produto.ValorCompra;
                    txtVendasValor.Content = valorVenda;
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
            produto.ProdutoID = Convert.ToInt32(inputCodigoProduto.Text);
            produto.Quantidade = Convert.ToInt32(qtdCompra.Text);

            if (produto.Quantidade == 0)
            {
                MessageBox.Show("Insira um valor inteiro");
            }
            else
            {
                if (venda.EditarVenda(produto))
                {
                    Venda novaVenda = new Venda();
                    novaVenda.ProdutoID = produto.ProdutoID;
                    novaVenda.Quantidade = produto.Quantidade;
                    novaVenda.ValorVenda = (Convert.ToDouble(txtVendasValor.Content) * produto.Quantidade);
                    novaVenda.UsuarioID = Session.usuario.UsuarioID;

                    venda.NovaVenda(novaVenda);

                    MessageBox.Show("Venda concluída com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível concluir a venda, verifique o estoque!");
                }
            }

        }
    }
}
