using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [Required, StringLength(11)]
        public string Cpf { get; set; }

        [Required, StringLength(20)]
        public string Senha { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public int PermissaoID { get; set; }

        public virtual Permissao _Permissao { get; set; }

        public bool Ativo { get; set; }
    }
}
