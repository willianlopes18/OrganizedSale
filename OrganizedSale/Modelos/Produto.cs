using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Produto
    {   
        [Key]
        public int ProdutoID { get; set; }

        [Required]
        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }

        [Required,StringLength(50)]
        public string Marca { get; set; }
        
        [Required]
        public string Modelo { get; set; }

        [Required]
        public string ValorCompra { get; set; }
    }
}
