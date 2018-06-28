using System.Collections.Generic;
using Controllers.Base;
using Modelos;

namespace Controllers
{
    class ProdutosController : IBaseController<Produto>
    {
        public void Adicionar(Produto entity)
        {
            throw new System.NotImplementedException();
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
    }
}
