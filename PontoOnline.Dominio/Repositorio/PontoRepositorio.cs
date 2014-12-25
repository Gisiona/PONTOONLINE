using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoOnline.Dominio.Entidades;
using System.Data.SqlClient;


namespace PontoOnline.Dominio.Repositorio
{
    public class PontoRepositorio
    {        
        /// <summary>
        /// Metodo responsavel por salvar os dados da marcacao de ponto
        /// </summary>
        public void SalvarPonto(Ponto p)
        {
            try
            {
                using(var ctx = new ContextPonto())
                {
                    ctx.Ponto.Add(p);
                    ctx.SaveChanges();
                }
            }
            catch (Exception sex)
            {
                throw new Exception("Ocorreu um erro ao tentar salvar os dados do ponto. Tente novamente. "+ sex.Message);
            }            
        }

        /// <summary>
        /// Metodo responsavel por atualizar os dados do ponto
        /// </summary>
        public void AtualizarPonto()
        {

        }


        /// <summary>
        /// Metodo responsavel por excluir os dados do ponto
        /// </summary>
        public void ExcluirPonto()
        {

        }

        /// <summary>
        /// Metodo responsavel por consultar dados da marcaçao do ponto
        /// </summary>
        public void ConsultarPonto()
        {

        }


        /// <summary>
        /// Metodo responsavel por consultar dados do ponto do mes.
        /// </summary>
        /// <param name="mes"></param>
        public void ConsultarPonto(string mes)
        {

        }
    }
}
