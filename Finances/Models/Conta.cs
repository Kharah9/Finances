using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finances.Models
{
    public class Conta
    {
        public int Id{ get; set; }
        [Required(ErrorMessage="Dê um nome a conta")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Selecione um tipo de conta")]
        public TipoConta Tipo { get; set; }
    }
}
