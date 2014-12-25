using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoOnline.Dominio.Entidades;
using PontoOnline.Dominio.Repositorio;


namespace PontoOnline.Negocio.Validacoes
{
    public static class PontoNegocio
    {
        /// <summary>
        /// Metodos responsavel por validar os dados vindo da camada de interface(View) e chamar a camada de 
        /// repositorio para salvar os dados no banco. Recebendo como paramentro um modelo ponto.
        /// </summary>
        /// <param name="p"> Ponto p</param>
        public static void SalvarPonto(Ponto p)
        {
            PontoRepositorio _repositorio = new PontoRepositorio();
            try
            {
                if (DateTime.Today != p.Data)
                {
                    throw new Exception("Não é permitido fazer lancamento de dias retroativo com seu usuário.");
                }
                else
                {
                    _repositorio.SalvarPonto(p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não é permitido fazer lancamento de dias retroativo com seu usuário. " + ex.Message + " - " + ex.InnerException);
            }
        }
    }
}
