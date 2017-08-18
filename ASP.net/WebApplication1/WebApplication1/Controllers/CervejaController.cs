using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class CervejaController : Controller
    {
        private static List<Cerva> _banco = new List<Cerva>();
        // GET: Cerveja
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Cerva cerva)
        {
            _banco.Add(cerva);
            TempData["mensagem"] = "Meus Parabens, vc e o rei do ASP.NET";
            return View();
        }

        
        public ActionResult Listar(Cerva cerva)
        {
            return View(_banco);
        }

    }
}