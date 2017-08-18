using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Cerva
    {
        [Display(Name = "Nome")]
        public string Nome
        {
            get;
            set;
        }
        [Display(Name = "Marca")]
        public string Marca
        {
            get;
            set;
        }
        [UIHint("Decimal")]
        [Display(Name = "Preço")]
        public decimal Preco
        {
            get;
            set;
        }
        [Display(Name = "Sem Alcool?")]
        public bool SemAlcool
        {
            get;
            set;
        }
        [Display(Name = "Tipo")]
        public string Tipo
        {
            get;
            set;
        }
        [Display(Name ="Data de validade")]
        [UIHint ("Date")]
        public DateTime Validade
        {
            get;
            set;
        }
    }
}