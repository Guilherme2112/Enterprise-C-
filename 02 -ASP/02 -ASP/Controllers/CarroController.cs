using _02__ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02__ASP.Controllers
{
    public class CarroController : Controller
    {
        // GET: Carro
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Carro carro)
        {
            return View();
        }

    }
}