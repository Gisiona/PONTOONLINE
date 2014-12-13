using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontoOnline.Dominio;


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
        public ActionResult Login(Usuario user)
        {
            return View();
        }

    }
}
