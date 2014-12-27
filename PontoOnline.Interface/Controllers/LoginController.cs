using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontoOnline.Dominio.Entidades;
using PontoOnline.Negocio;


namespace PontoOnline.Interface.Controllers
{
    public class LoginController : Controller
    {
        /// <summary>
        /// GET: /Login/
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }


        /// <summary>
        /// POST: /Login/
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public RedirectToRouteResult Login(string user, string senha, string returnUrl)
        {
            try
            {
                if (PontoOnline.Negocio.LoginNegocio.Login(user, senha))
                {
                    return RedirectToAction("Ponto", "PontoOnline");
                }
                else
                {
                    return RedirectToAction("Login", new { returnUrl });
                }                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message, ex.InnerException);
            }
        }
    }
}
