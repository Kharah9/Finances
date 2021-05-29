using System;
using System.ComponentModel.DataAnnotations;

namespace Finances.Models
{
    public abstract class MovimentacaoBase
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Digite uma descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Digite um valor")]
        public decimal Valor { get; set; }
        public bool Recorrente { get; set; }
        [Required(ErrorMessage = "Escolha um tipo de conta")]
        public TipoConta Conta { get; set; }
        [Display(Name = "Movimentação")]
        [Required(ErrorMessage = "Escolha um tipo de movimentação")]
        public TipoMovimentacao Movimentacao { get; set; }
        [Required(ErrorMessage = "Digite a data da movimentação")]
        public DateTime DataMovimentacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Excluido { get; set; }
    }
}
