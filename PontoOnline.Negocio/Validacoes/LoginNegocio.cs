using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoOnline.Dominio.Entidades;
using PontoOnline.Dominio.Repositorio;

namespace PontoOnline.Negocio
{
    public class LoginNegocio
    {
        /// <summary>
        /// Metodo para validar os dados do login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Login(string user, string senha)
        {
            try            {
                if (string.IsNullOrEmpty(user.Trim().ToString()))
                {
                    throw new Exception("Erro: O campo usuário não pode ser vazio. Digite o usuário.");
                }
                else if (string.IsNullOrEmpty(senha.Trim().ToString()))
                {
                    throw new Exception("Erro: O campo senha não pode ser vazio. Digite a senha.");
                }
                else
                {
                   var repositorioLogin =  PontoOnline.Dominio.Repositorio.LoginRepositorio.Login(user, senha);
                   return repositorioLogin;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro na validação do login \n" + ex.Message, ex.InnerException);
            }
        }


        /// <summary>
        /// Metodo para criptografar a string de conexao 
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public string EncryptConnectionString(string password, string user)
        {
            Byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(password + user);
            string encryptedConnectionString = Convert.ToBase64String(b);
            return encryptedConnectionString;
        }


        /// <summary>
        /// Metodo que descriptografa a string de conexao
        /// </summary>
        /// <returns></returns>
        public string DecryptConnectionString(Usuario user)
        {
            Byte[] b = Convert.FromBase64String(user.Senha + user.Nome);
            string decryptedConnectionString = System.Text.ASCIIEncoding.ASCII.GetString(b);
            return decryptedConnectionString;
        }
    }
}

