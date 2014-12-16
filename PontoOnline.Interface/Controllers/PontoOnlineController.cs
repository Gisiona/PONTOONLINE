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
            Ponto p = new Ponto
            {
                IdPonto = 1,
                Data = DateTime.Now,
                Entrada = "09:00:00",
                SaidaAlmoco = "12:30:00",
                EntradaAlmoco = "13:30:10",
                SaidaEmbora = "18:23:30"
            };
            return View(p.ToString());
        }

        [HttpPost]
        public ActionResult Ponto(Ponto ponto)
        {
            Ponto p = new Ponto
            {
                IdPonto = 1,
                Data = DateTime.Now,
                Entrada = "09:00:00",
                SaidaAlmoco = "12:30:00",
                EntradaAlmoco = "13:30:10",
                SaidaEmbora = "18:23:30"
            };
            return View(p);
        }

    }
}
