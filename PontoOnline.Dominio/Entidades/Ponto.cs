using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoOnline.Dominio.Entidades
{
   public class Ponto
    {
        public int IdPonto { get; set; }
        public DateTime Data { get; set; }
        public string Entrada { get; set; }
        public string SaidaAlmoco { get; set; }
        public string EntradaAlmoco { get; set; }
        public string SaidaEmbora { get; set; }
        public TimeSpan QtdeHoraExtra { get; set; }
        public TimeSpan TotalHoraTrabalhada { get; set; }
    }
}
