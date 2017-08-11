using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02__ASP.Models
{
    public class Paciente
    {
        public String nome { get; set; }
        public DateTime dtNasc { get; set; }
        public int convenio { get; set; }
        public String tipo{get;set;}


    }
}