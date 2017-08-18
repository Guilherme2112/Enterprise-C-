using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cerveja1.Models
{
    public class Cerveja
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Fabricante")]

        public string Marca { get; set; }
        [Display(Name = "Preço")]

        public decimal Preco { get; set; }
        [Display(Name = "Sem Alcool?")]

        public bool SemAlcool { get; set; }
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }
        [UIHint("Date")]
        [Display(Name ="Data de Validade")]
        public DateTime Validade { get; set; }



    }
}