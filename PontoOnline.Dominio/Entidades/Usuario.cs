using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PontoOnline.Dominio.Entidades
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
        public bool LembrarSenha { get; set; }
    }
}
