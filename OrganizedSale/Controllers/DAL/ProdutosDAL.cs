using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers.DAL
{
    class ProdutosDAL
    {
        Contexto contexto = new Contexto();

        public IList<Categoria> ListCategorias()
        {
            return contexto.Categorias.ToList();
        }

        public int Create(Produto entity)
        {
            contexto.Produtos.Add(entity);
            contexto.SaveChanges();

            return entity.ProdutoID;
        }
    }
}
