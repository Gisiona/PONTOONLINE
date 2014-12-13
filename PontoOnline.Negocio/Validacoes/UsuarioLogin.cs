using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoOnline.Dominio;

namespace PontoOnline.Negocio
{
    public class UsuarioLogin
    {
        public void Login(Usuario user)
        {
            try
            {
                if (string.IsNullOrEmpty(user.Nome.Trim().ToString()))
                {
                    throw new Exception("Erro: O campo usuário não pode ser vazio. Digite o usuário.");
                }
                else if(string.IsNullOrEmpty(user.Senha.Trim().ToString()))
                {
                    throw new Exception("Erro: O campo senha não pode ser vazio. Digite a senha.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro na validação do login \n" + ex.Message);
            }
        }
    }
}

