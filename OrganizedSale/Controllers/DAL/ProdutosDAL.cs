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

        public bool edit(Produto entity)
        {
            var sql = contexto.Produtos.SingleOrDefault(prod => prod.ProdutoID == entity.ProdutoID);

            try
            {
                if (sql.Quantidade >= entity.Quantidade)
                {
                    sql.Quantidade = sql.Quantidade - entity.Quantidade;
                    contexto.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }                
            }
            catch (System.Exception)
            {

                return false;
            }                        
        }

        public Produto search(int id)
        {
            return contexto.Produtos.Find(id);
        }

        public int Create(Produto entity)
        {
            contexto.Produtos.Add(entity);
            contexto.SaveChanges();

            return entity.ProdutoID;
        }

        public int CreateSell(Venda entity)
        {
            contexto.Vendas.Add(entity);
            contexto.SaveChanges();

            return entity.VendaId;
        }

        public IList<Produto> ListProdutos()
        {
            return contexto.Produtos.ToList();
        }
    }
}
