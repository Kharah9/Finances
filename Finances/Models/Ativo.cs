
using System.ComponentModel.DataAnnotations.Schema;

namespace Finances.Models
{
    public class Ativo : MovimentacaoBase
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Rendimento { get; set; }
    }
}
