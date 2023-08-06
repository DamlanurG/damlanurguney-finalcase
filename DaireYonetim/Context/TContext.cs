using DaireYonetim.Entity;
using Microsoft.EntityFrameworkCore;

namespace DaireYonetim.Context
{
    public class TContext : DbContext
    {
        public virtual DbSet<Daire> Daire { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Aidat> Aidat { get; set; }
        public virtual DbSet<Fatura> Fatura { get; set; }
        public virtual DbSet<Mesaj> Mesaj { get; set; }

        public TContext(DbContextOptions<TContext> options) :
            base(options)
        {
        }
    }
}
