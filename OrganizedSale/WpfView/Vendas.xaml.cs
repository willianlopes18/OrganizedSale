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
                    txtVendasValor.Content = produto.
                }
                else
                {
                    txtVendasProduto.Content = "";
                }
            }
            else
            {
                txtVendasProduto.Content = "";
            }
            

        }
    }
}
