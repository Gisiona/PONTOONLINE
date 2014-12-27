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
        public int UsuarioId { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public TimeSpan Entrada { get; set; }
        public TimeSpan SaidaAlmoco { get; set; }
        public TimeSpan EntradaAlmoco { get; set; }
        public TimeSpan SaidaEmbora { get; set; }
        public TimeSpan QtdeHoraExtra { get; set; }
        public TimeSpan TotalHoraTrabalhada { get; set; }
        public IEnumerable<Usuario> Usuario { get; set; }
    }

    public enum PontoMes
    {
        Janeiro,
        Fevereiro,
        Março,
        Abril,
        Maio,
        Junho,
        Julho,
        Agosto,
        Setembro,
        Outubro,
        Novembro,
        Dezembro
    }
}
