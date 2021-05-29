using Microsoft.EntityFrameworkCore;

namespace Finances.Models
{
    public partial class Context : DbContext
    {
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Saida> Saidas { get; set; }
        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<TipoConta> TiposConta { get; set; }
        public DbSet<TipoMovimentacao> TiposMovimentacao { get; set; }

        public Context() 
        { }

        public Context(DbContextOptions<Context> options)
            :base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //optionBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-PMKK6DC;Database=FinancesDB;Integrated Security=True");
        }

    }
}
