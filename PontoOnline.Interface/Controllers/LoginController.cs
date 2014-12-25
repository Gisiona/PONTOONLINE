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
        public ActionResult Login(string user, string senha, string Url)
        {
            try
            {
                if(PontoOnline.Negocio.LoginNegocio.Login(user, senha))
                {
                    return Redirect(Url);
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {                
                throw;
            }
        }        
    }
}
