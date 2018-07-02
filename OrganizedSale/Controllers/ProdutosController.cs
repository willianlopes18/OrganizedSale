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

        public Produto BuscarPorID(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Editar(Produto entity)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public IList<Categoria> ListarCategorias()
        {
            return produtosDAL.ListCategorias();
        }
    }
}
