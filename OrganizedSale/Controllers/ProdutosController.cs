using System.Collections.Generic;
using Controllers.Base;
using Controllers.DAL;
using Modelos;

namespace Controllers
{
    public class ProdutosController : IBaseController<Produto>
    {
        private ProdutosDAL produtosDAL = new ProdutosDAL();

        public void Adicionar(Produto entity)
        {
            produtosDAL.Create(entity);
        }

        public bool NovaVenda(Venda entity)
        {
            if (produtosDAL.CreateSell(entity) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Produto BuscarPorID(int id)
        {
            return produtosDAL.search(id);
        }

        public bool EditarVenda(Produto entity)
        {
            return produtosDAL.edit(entity);
        }

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Produto> ListarPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public IList<Produto> ListarTodos()
        {
            return produtosDAL.ListProdutos();
        }

        public IList<Categoria> ListarCategorias()
        {
            return produtosDAL.ListCategorias();
        }

        public void Editar(Produto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
