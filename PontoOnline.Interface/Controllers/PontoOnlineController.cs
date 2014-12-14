using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontoOnline.Dominio.Entidades;

namespace PontoOnline.Interface.Controllers
{
    public class PontoOnlineController : Controller
    {
        //
        // GET: /PontoOnline/
        public ActionResult Ponto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ponto(Ponto ponto)
        {
            return View();
        }

    }
}
