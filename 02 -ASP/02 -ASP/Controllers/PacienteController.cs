using _02__ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02__ASP.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Cadastro()
        {
            return View("Cadastro");
        }
        public ActionResult Gravar(Paciente paciente)
        {
            //return Content("Nome: "+paciente.nome+", Sangue tipo "+paciente.tipo+".");
            //viewbag transmite dados para  a view para a qual o metodo redireciona
            TempData["msg"] = "Gravou!";
            ViewBag.data = paciente.dtNasc;
            ViewBag.nome = paciente.nome;
            ViewBag.convenio = paciente.convenio;
            ViewBag.tipo = paciente.tipo;
            return View(paciente);
        }

    }
}