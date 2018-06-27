using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Permissao
    {
        [Key]
        public int PermissaoID { get; set; }

        [Required]
        public string TipoPermissao { get; set; }
    }
}
