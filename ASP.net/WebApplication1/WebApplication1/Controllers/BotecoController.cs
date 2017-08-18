using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BotecoController : Controller
    {
        //Simulando um  bd
        private static List<Boteco> _banco = new List<Boteco>(); 
        // GET: Boteco
        [HttpGet]
        public ActionResult ShowCadastroForm()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult ShowCadastroForm(Boteco boteco)
        {
            _banco.Add(boteco);
            TempData["msg"] = "Sucesso!";
            return View();
        }
        
      public ActionResult Listar()
        {
            return View(_banco);
        }
        
    }
} 