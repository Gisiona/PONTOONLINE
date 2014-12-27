using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontoOnline.Dominio.Entidades;
using PontoOnline.Negocio.Validacoes;

namespace PontoOnline.Interface.Controllers
{
    public class PontoOnlineController : Controller
    {
        //
        // GET: /PontoOnline/

        public ActionResult PontoOnline()
        {
            return View();
        }

        public ActionResult Ponto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ponto(Ponto ponto)
        {
            return View();
        }


        public ActionResult PontoMarcacao(int id = 0, string returnUrl = null)
        {
            try
            {
                return View(PontoNegocio.ListarPonto(id));
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost]
        public ActionResult PontoMarcacao(int id)
        {
            try
            {
                return View(PontoNegocio.ListarPonto(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
