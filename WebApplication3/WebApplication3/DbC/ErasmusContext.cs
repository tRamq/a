using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.DbC
{
    public class ErasmusContext : DbContext
    {
        public ErasmusContext():base ("ErasmusContext")
        {
        }
        public DbSet<Universite> Universite { get; set; }
        public DbSet<Konaklama> Konaklama { get; set; }
        public DbSet<IsImkanlari> IsImkanlari { get; set; }
        public DbSet<Uye> Uye { get; set; }
        public DbSet<YetkiKisi> yetkiKisi { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}