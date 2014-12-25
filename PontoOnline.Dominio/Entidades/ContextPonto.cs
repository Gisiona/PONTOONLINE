using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PontoOnline.Dominio.Entidades
{
    public class ContextPonto : DbContext
    {
        public DbSet<Ponto> Ponto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public ContextPonto()
            : base("PontoOnline")
        {

        }
    }
}
