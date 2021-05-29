using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finances.Models
{
    public class Ativo : MovimentacaoBase
    {
        public decimal Rendimento { get; set; }
    }
}
