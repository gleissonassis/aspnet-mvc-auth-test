using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SessionTest.Models;

namespace SessionTest.Controllers
{
    public class UsuariosController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        public ActionResult Auth() 
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Auth(Usuario modelo, string returnUrl)
        {
            if (modelo.Email == "gleisson.assis@gmail.com" && modelo.Senha == "teste123")
            {
                FormsAuthentication.SetAuthCookie(modelo.Email, false);
                Session["email"] = modelo.Email;

                if (this.Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(modelo);
        }

        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}
