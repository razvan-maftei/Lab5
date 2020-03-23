using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator5
{
    class PhotographContext : DbContext
    {
        public DbSet<Photograph> PhotographSet { get; set; }
        public DbSet<PhotographFullImage> PhotographFullImageSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
                .HasRequired(p => p.PhotographFullImage)
                .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
                .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
                .ToTable("Photograph", "BazaDeDate");
        }
    }
}
