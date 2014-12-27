using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoOnline.Dominio.Entidades;
using System.Configuration;
using System.Data.SqlClient;

namespace PontoOnline.Dominio.Repositorio
{
    public static class LoginRepositorio
    {

        public static bool Login(string user, string senha)
        {
            ContextPonto ctx = new ContextPonto();
            try
            {
                var usuario = ctx.Usuario.Where(m => m.Nome == user && m.Senha == senha);
                var use = usuario.ToString();
                if (usuario.Count() > 1)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu algum erro ao validar usário e senha." + ex.Message);
            }
        }
    }
}
