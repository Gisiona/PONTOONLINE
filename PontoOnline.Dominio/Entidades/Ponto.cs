using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PontoOnline.Dominio.Entidades
{
    [Table("Ponto")]
    public class Ponto
    {
        [Key]
        public int IdPonto { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public string Entrada { get; set; }
        public string SaidaAlmoco { get; set; }
        public string EntradaAlmoco { get; set; }
        public string SaidaEmbora { get; set; }
        public TimeSpan QtdeHoraExtra { get; set; }
        public TimeSpan TotalHoraTrabalhada { get; set; }
    }
}
