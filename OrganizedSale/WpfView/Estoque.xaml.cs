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
    /// Lógica interna para Estoque.xaml
    /// </summary>
    public partial class Estoque : Window
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProdutosController produtosController = new ProdutosController();            
            dgProdutos.DataContext = produtosController.ListarTodos();
        }

        private void Excluir(object sender, RoutedEventArgs e)
        {            
            ProdutosController produtosController = new ProdutosController();
            var prod = dgProdutos.SelectedItem as Produto;
            produtosController.Excluir(prod.ProdutoID);
            Window_Loaded(sender, e);   
        }

        private void EditarProduto(object sender, RoutedEventArgs e)
        {            
            var prod = dgProdutos.SelectedItem as Produto;
            EditarProduto editar = new EditarProduto(prod.ProdutoID);
            editar.ShowDialog();
            Window_Loaded(sender, e);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Produto prod = (Produto)dg.Items[dg.SelectedIndex];        
        }
    }
}
