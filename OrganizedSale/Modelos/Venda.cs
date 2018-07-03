namespace Modelos
{
    public class Venda
    {
        public int VendaId { get; set; }

        public int ProdutoID { get; set; }

        public virtual Produto _Produto { get; set; }

        public double ValorVenda { get; set; }

        public int UsuarioID { get; set; }

        public virtual Usuario _Usuario { get; set; }

        public int Quantidade { get; set; }
    }
}
