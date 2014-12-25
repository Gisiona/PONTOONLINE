using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoOnline.Dominio.Entidades;

namespace PontoOnline.Dominio.Repositorio
{
    public static class LoginRepositorio
    {
        public static bool Login(string user, string senha)
        {
            try
            {
                using (var ctx = new ContextPonto())
                {
                    var usuario = ctx.Usuario.Where(m => m.Nome == user && m.Senha == senha);
                    if (usuario.Count() > 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu algum erro ao validar usário e senha." + ex.Message);
            }
        }
    }
}
