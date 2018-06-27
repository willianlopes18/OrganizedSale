namespace Modelos
{
    public class Venda
    {
        public int VendaId { get; set; }

        public int ProdutoID { get; set; }

        public virtual Produto _Produto { get; set; }

        public float ValorVenda { get; set; }

        public int Usuario { get; set; }

        public virtual Usuario _Usuario { get; set; }
    }
}
