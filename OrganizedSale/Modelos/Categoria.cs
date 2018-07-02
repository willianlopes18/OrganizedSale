using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Categoria
    {   
        [Key]
        public int CategoriaID { get; set; }


        public string Tipo { get; set; }
        
        public override string ToString() { return Tipo; }
    }
}
