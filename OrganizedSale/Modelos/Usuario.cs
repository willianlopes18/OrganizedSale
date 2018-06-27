using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required, StringLength(11)]
        public string Cpf { get; set; }

        [Required, StringLength(20)]
        public string Senha { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        public bool Ativo { get; set; }
    }
}
