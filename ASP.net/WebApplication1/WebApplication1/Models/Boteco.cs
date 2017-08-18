using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Boteco
    {
        public int id { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }
        [Display(Name = "Música ao Vivo")]
        public bool MusicaAoVivo { get; set; }

        [Display(Name = "Endereço")]
        public String Endereco { get; set; }
        [Display(Name = "Data de Inauguração")]
        [UIHint("Date")]
        public DateTime DataDeInauguracao { get; set; }

    }
}