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

        public void editProd(Produto entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public Produto find(int id)
        {
            return contexto.Produtos.Find(id);
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

        public void Delete(Produto id)
        {
            contexto.Produtos.Remove(id);
            contexto.SaveChanges();
        }

        public int CreateSell(Venda entity)
        {
            contexto.Vendas.Add(entity);
            contexto.SaveChanges();

            return entity.VendaId;
        }

        public IList<Produto> ListProdutos()
        {
            var query = from prod in contexto.Produtos select prod;
            return query.ToList();
        }
        public IList<Venda> ListVendas()
        {
            var query = from venda in contexto.Vendas select venda;
            return query.ToList();
        }
    }
}
