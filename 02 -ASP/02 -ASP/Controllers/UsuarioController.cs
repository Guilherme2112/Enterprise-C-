using _02__ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02__ASP.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Gravar(Usuario usr)
        {
            TempData["mensagem"] = "Usuário Cadastrado!";
            return View(usr);
        }
    }
}